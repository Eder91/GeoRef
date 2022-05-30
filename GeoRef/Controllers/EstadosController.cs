using GeoRef.Models;
using GeoRef.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeoRef.Controllers
{
    public class EstadosController : Controller
    {
        private readonly IEstadosService _estadosService;
        public EstadosController(IEstadosService estadosService)
        {
            _estadosService = estadosService;
        }

        public async Task<IActionResult> EstadoIndex()
        {
            List<EstadosDto> list = new();
            var response = await _estadosService.GetAllEstadosAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<EstadosDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
        public async Task<IActionResult> EstadoCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EstadoCreate(EstadosDto estadosDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _estadosService.CreateEstadoAsync<ResponseDto>(estadosDto);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(EstadoIndex));
                }
            }
            return View(estadosDto);
        }
        public async Task<IActionResult> EstadoEdit(int idEstado)
        {
            var response = await _estadosService.GetEstadoByIdAsync<ResponseDto>(idEstado);
            if (response != null && response.IsSuccess)
            {
                EstadosDto estados = JsonConvert.DeserializeObject<EstadosDto>(Convert.ToString(response.Result));
                return View(estados);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EstadoEdit(EstadosDto estadosDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _estadosService.UpdateEstadosAsync<ResponseDto>(estadosDto);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(EstadoIndex));
                }
            }
            return View(estadosDto);
        }
        public async Task<IActionResult> EstadoDelete(int idEstado)
        {
            var response = await _estadosService.GetEstadoByIdAsync<ResponseDto>(idEstado);
            if (response != null && response.IsSuccess)
            {
                EstadosDto estadosDto = JsonConvert.DeserializeObject<EstadosDto>(Convert.ToString(response.Result));
                return View(estadosDto);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EstadoDelete(EstadosDto estadosDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _estadosService.DeleteEstadoAsync<ResponseDto>(estadosDto.idEstado);
                if (response.IsSuccess)
                {
                    return RedirectToAction(nameof(EstadoIndex));
                }
            }
            return View(estadosDto);
        }
    }
}
