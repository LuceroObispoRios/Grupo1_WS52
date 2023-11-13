using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Controllers;

[ApiController]
[Route("/api/v1/booking-history")]
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
    [ProducesResponseType(typeof(IEnumerable<BookingHistoryResource>), 200)]
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


        
    [HttpGet("idClient/{clientId}")]
    [ProducesResponseType(typeof(IEnumerable<BookingHistoryResource>), 200)]
    public async Task<ActionResult<BookingHistoryResource>> GetBookingsByClientId(int clientId)
    {
        var booking = await _bookingHistoryService.GetBookingsByClientIdAsync(clientId);

        if (booking == null)
        {
            return NotFound();
        }

        var bookingResource = _mapper.Map<IEnumerable<BookingHistory>, IEnumerable<BookingHistoryResource>>(booking);
        return Ok(bookingResource);
    }
    
    [HttpGet("idCompany/{companyId}")]
    [ProducesResponseType(typeof(IEnumerable<BookingHistoryResource>), 200)]
    public async Task<ActionResult<BookingHistoryResource>> GetBookingsByCompanyId(int companyId)
    {
        var booking = await _bookingHistoryService.GetBookingsByClientIdAsync(companyId);

        if (booking == null)
        {
            return NotFound();
        }

        var bookingResource = _mapper.Map<IEnumerable<BookingHistory>, IEnumerable<BookingHistoryResource>>(booking);
        return Ok(bookingResource);
    }

    

    [HttpPost]
    [ProducesResponseType(typeof(BookingHistoryResource), 201)]
    [ProducesResponseType(typeof(List<string>), 400)]
    [ProducesResponseType(500)]
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
