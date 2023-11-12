using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Controllers;

[ApiController]
[Route("/api/v1/clients/{clientId}/companies")]
public class BookingHistoryController : ControllerBase{
    private readonly IBookingHistoryService _bookingHistoryService;
    private readonly IMapper _mapper;

    public BookingHistoryController(IBookingHistoryService bookingHistoryService, IMapper mapper)
    {
        _bookingHistoryService = bookingHistoryService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<BookingHistoryResource>> GetAllAsync()
    {
        var bookings = await _bookingHistoryService.GetBookingHistoryAsync();
        var resources = _mapper.Map<IEnumerable<BookingHistory>, IEnumerable<BookingHistoryResource>>(bookings);
        return resources;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BookingHistoryResource>> GetBooking(int id)
    {
        var booking = await _bookingHistoryService.GetBookingAsync(id);

        if (booking == null)
        {
            return NotFound();
        }

        var bookingResource = _mapper.Map<BookingHistory, BookingHistoryResource>(booking);
        return Ok(bookingResource);
    }

    [HttpPost]
    public async Task<ActionResult<BookingHistoryResource>> CreateBooking([FromBody] SaveBookingHistoryResource resource)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }

        var booking = _mapper.Map<SaveBookingHistoryResource, BookingHistory>(resource);
        var response = await _bookingHistoryService.CreateBookingAsync(booking);

        if (!response.Success)
        {
            return BadRequest(new { error = response.Message });
        }

        var bookingResource = _mapper.Map<BookingHistory, BookingHistoryResource>(response.Resource);
        return CreatedAtAction("GetBooking", new { id = bookingResource.Id }, bookingResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBooking(int id, [FromBody] SaveBookingHistoryResource resource)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }

        var booking = _mapper.Map<SaveBookingHistoryResource, BookingHistory>(resource);
        var response = await _bookingHistoryService.UpdateBookingAsync(id, booking);

        if (!response.Success)
        {
            return BadRequest(new { error = response.Message });
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var response = await _bookingHistoryService.DeleteBookingAsync(id);

        if (!response.Success)
        {
            return BadRequest(new { error = response.Message });
        }

        return NoContent();
    }
}
