using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CargaSinEstres.API.CargaSinEstres.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ReviewsController : ControllerBase {
 
    private readonly IReviewService _reviewService;
    private readonly IMapper _mapper;


    public ReviewsController(IReviewService reviewService, IMapper mapper)
    {
        _reviewService = reviewService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<ReviewResource>> GetAllAsync()
    {
        var reviews = await _reviewService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewResource>>(reviews);
        return resources;

    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveReviewResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());
        
        var tutorial = _mapper.Map<SaveReviewResource, Review>(resource);
        var result = await _reviewService.SaveAsync(tutorial); if (!result.Success)
            return BadRequest(result.Message);
        var tutorialResource = _mapper.Map<Review, ReviewResource>(result.Resource); return Ok(tutorialResource);
    }
}