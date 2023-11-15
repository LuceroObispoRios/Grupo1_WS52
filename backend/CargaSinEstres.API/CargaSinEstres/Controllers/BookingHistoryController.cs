using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Security.Domain.Services;
using CargaSinEstres.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Controllers;

[ApiController]
[Route("/api/v1/booking-history")]
public class BookingHistoryController : ControllerBase{
    private readonly IBookingHistoryService _bookingHistoryService;
    private readonly IMapper _mapper;
    private readonly ICompanyService _companyService;

    public BookingHistoryController(IBookingHistoryService bookingHistoryService, IMapper mapper, ICompanyService companyService)
    {
        _bookingHistoryService = bookingHistoryService;
        _mapper = mapper;
        _companyService = companyService;
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
        var booking = await _bookingHistoryService.GetBookingsByCompanyIdAsync(companyId);

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
        
        // aqui esta el hiredCompany
        var hiredCompany = await _companyService.GetByIdAsync(resource.IdCompany);
        if (hiredCompany == null)
        {
            return NotFound();
        }
        // set hired company id
        booking.HiredCompany.Name = hiredCompany.Name;
        booking.HiredCompany.Logo = hiredCompany.Photo;
        
        // set payment
        booking.Payment.TotalAmount = 0;
        booking.Payment.PaymentMethod = "";
        
        
        
        var response = await _bookingHistoryService.CreateBookingAsync(booking);

        if (!response.Success)
        {
            return BadRequest(new { error = response.Message });
        }

        var bookingResource = _mapper.Map<BookingHistory, BookingHistoryResource>(response.Resource);
        return CreatedAtAction("GetBooking", new { id = bookingResource.Id }, bookingResource);
    }
    
    
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(SaveChatResource), 201)]
    public async Task<IActionResult> CreateMessage(int id, [FromBody] SaveChatResource newMessage)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var existingBooking = await _bookingHistoryService.GetBookingAsync(id);

        if (existingBooking == null)
            return NotFound();
        
        newMessage.DateTime = DateTime.Now;
        
        // Agregar nuevos mensajes al historial de chat existente
        //existingBooking.Chats.Add(newMessage);
        var chat = _mapper.Map<SaveChatResource, Chat>(newMessage);
        existingBooking.Chats.Add(chat);

        var response = await _bookingHistoryService.UpdateBookingAsync(id, existingBooking);

        if (!response.Success)
            return BadRequest(new { error = response.Message });

        return CreatedAtAction("CreateMessage", new { id = existingBooking.Id }, newMessage);
    }


    
    // [HttpPut]
    // [ProducesResponseType(typeof(BookingHistoryResource), 201)]
    // [ProducesResponseType(typeof(List<string>), 400)]
    // [ProducesResponseType(500)]
    // public async Task<ActionResult<BookingHistoryResource>> CreateMessage(int bookingId, [FromBody] SaveBookingHistoryResource resource)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState.GetErrorMessages());
    //     }
    //
    //     var booking = _mapper.Map<SaveBookingHistoryResource, BookingHistory>(resource);
    //     var response = await _bookingHistoryService.UpdateBookingAsync(bookingId, booking);
    //
    //     if (!response.Success)
    //     {
    //         return BadRequest(new { error = response.Message });
    //     }
    //
    //     return NoContent();
    // }
    //
    // [HttpPut("{id}")]
    // public async Task<IActionResult> UpdateBooking(int id, [FromBody] SaveBookingHistoryResource resource)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState.GetErrorMessages());
    //     }
    //
    //     var booking = _mapper.Map<SaveBookingHistoryResource, BookingHistory>(resource);
    //     var response = await _bookingHistoryService.UpdateBookingAsync(id, booking);
    //
    //     if (!response.Success)
    //     {
    //         return BadRequest(new { error = response.Message });
    //     }
    //
    //     return NoContent();
    // }

    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteBooking(int id)
    // {
    //     var response = await _bookingHistoryService.DeleteBookingAsync(id);
    //
    //     if (!response.Success)
    //     {
    //         return BadRequest(new { error = response.Message });
    //     }
    //
    //     return NoContent();
    // }
}
