using AutoMapper;
using GeoReferenceAPI.DbContexts;
using GeoReferenceAPI.Models;
using GeoReferenceAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GeoReferenceAPI.Repository
{
    public class GeoReferenceRepository : IGeoReferenceRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public GeoReferenceRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<GeoReferenceDto> CreateUpdateGeoReference(GeoReferenceDto geoReferenceDto)
        {
            GeoReference geoReference = _mapper.Map<GeoReferenceDto, GeoReference>(geoReferenceDto);
            try
            {
                if (geoReferenceDto.idGeoreferencia > 0)
                {
                    _db.GeoReferences.Update(geoReference);
                }
                else
                {
                    _db.GeoReferences.Add(geoReference);
                }
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            return _mapper.Map<GeoReference, GeoReferenceDto>(geoReference);
        }

        public async Task<bool> DeleteGeoReference(int id)
        {
            try
            {
                GeoReference geoReference = await _db.GeoReferences.FirstOrDefaultAsync(x => x.idGeoreferencia == id);
                if (geoReference == null)
                {
                    return false;
                }
                _db.GeoReferences.Remove(geoReference);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<GeoReferenceDto> GetDataByGeoRef(int id)
        {
            GeoReference geoReference = await _db.GeoReferences.Where(x => x.idGeoreferencia == id).FirstOrDefaultAsync();
            geoReference.Estados =  await _db.Estados.Where(x => x.idEstado == geoReference.idEstado).FirstOrDefaultAsync();
            return _mapper.Map<GeoReference, GeoReferenceDto>(geoReference);
        }

        public Task<GeoReferenceVM> GetEstados()
        {
            GeoReferenceVM geoReference = new GeoReferenceVM()
            {
                TypeDropDown = _db.Estados.Select(x => new SelectListItem
                {
                    Text = x.Descripcion,
                    Value = x.idEstado.ToString()
                })
            };
            return Task.FromResult(_mapper.Map<GeoReferenceVM>(geoReference));
        }

        public async Task<IEnumerable<GeoReferenceDto>> GetGeoReferences()
        {
            IEnumerable<GeoReference> geoReferences = await _db.GeoReferences.ToListAsync();
            foreach (var obj in geoReferences)
            {
                obj.Estados = await _db.Estados.Where(x => x.idEstado == obj.idEstado).FirstOrDefaultAsync();
            }
            return _mapper.Map<List<GeoReferenceDto>>(geoReferences);
        }
    }
}
