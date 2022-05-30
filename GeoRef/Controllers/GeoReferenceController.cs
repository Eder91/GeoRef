using GeoRef.Models;
using GeoRef.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeoRef.Controllers
{
    public class GeoReferenceController : Controller
    {
        private readonly IGeoReferencesService _geoReferencesService;
        public GeoReferenceController(IGeoReferencesService geoReferencesService)
        {
            _geoReferencesService = geoReferencesService;
        }

        public async Task<IActionResult> GeoReferenceIndex()
        {
            List<GeoReferenceDto> list = new();
            var response = await _geoReferencesService.GetAllGeoReferenceAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<GeoReferenceDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
        public async Task<IActionResult> GeoReferenceCreate()
        {
            var response = await _geoReferencesService.GetEstados<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                GeoReferenceVM geoReferenceVM = JsonConvert.DeserializeObject<GeoReferenceVM>(Convert.ToString(response.Result));
                ViewBag.EstadosList = geoReferenceVM.TypeDropDown;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GeoReferenceCreate(GeoReferenceDto geoReferenceDto)
        {
            ModelState.Remove("Estados");
            if (ModelState.IsValid)
            {
                var response = await _geoReferencesService.CreateGeoReferenceAsync<ResponseDto>(geoReferenceDto);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(GeoReferenceIndex));
                }
            }
            return View(geoReferenceDto);
        }
        public async Task<IActionResult> GeoReferenceEdit(int idGeoReference)
        {
            var response = await _geoReferencesService.GetGeoReferenceByIdAsync<ResponseDto>(idGeoReference);
            var response2 = await _geoReferencesService.GetEstados<ResponseDto>();
            if (response2 != null && response2.IsSuccess)
            {
                GeoReferenceVM geoReferenceVM = JsonConvert.DeserializeObject<GeoReferenceVM>(Convert.ToString(response2.Result));
                ViewBag.EstadosList = geoReferenceVM.TypeDropDown;
            }
            if (response != null && response.IsSuccess)
            {
                GeoReferenceDto geoReference = JsonConvert.DeserializeObject<GeoReferenceDto>(Convert.ToString(response.Result));
                return View(geoReference);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> GeoReferenceEdit(GeoReferenceDto geoReferenceDto)
        {
            ModelState.Remove("Estados");
            if (ModelState.IsValid)
            {
                var response = await _geoReferencesService.UpdateGeoReferenceAsync<ResponseDto>(geoReferenceDto);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(GeoReferenceIndex));
                }
            }
            return View(geoReferenceDto);
        }
        public async Task<IActionResult> GeoReferenceDelete(int idGeoReference)
        {
            var response = await _geoReferencesService.GetGeoReferenceByIdAsync<ResponseDto>(idGeoReference);
            var response2 = await _geoReferencesService.GetEstados<ResponseDto>();
            if (response2 != null && response2.IsSuccess)
            {
                GeoReferenceVM geoReferenceVM = JsonConvert.DeserializeObject<GeoReferenceVM>(Convert.ToString(response2.Result));
                ViewBag.EstadosList = geoReferenceVM.TypeDropDown;
            }
            if (response != null && response.IsSuccess)
            {
                GeoReferenceDto geoReference = JsonConvert.DeserializeObject<GeoReferenceDto>(Convert.ToString(response.Result));
                return View(geoReference);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> GeoReferenceDelete(GeoReferenceDto geoReferenceDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _geoReferencesService.DeleteGeoReferenceAsync<ResponseDto>(geoReferenceDto.idGeoreferencia);
                if (response.IsSuccess)
                {
                    return RedirectToAction(nameof(GeoReferenceIndex));
                }
            }
            return View(geoReferenceDto);
        }
    }
}
