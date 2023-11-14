using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Resources;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Controllers;

[ApiController]
[Route("/api/v1/clients/{clientId}/companies")]
public class BookingHistoryController : ControllerBase{
}