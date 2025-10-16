using System;
using AutoMapper;
using CiudadanosServicesCS.NombresPropios.Models;
using CiudadanosServicesCS.NombresPropios.Models.Dtos;

namespace CiudadanosServicesCS.NombresPropios.Mapper;
    public class NombrePropioMapper : Profile
    {
        public NombrePropioMapper()
        {
            CreateMap<NombrePropioEntity, NombrePropioDto>().ReverseMap();
            CreateMap<NombrePropioEntity, CreateNombrePropioDto>().ReverseMap();
        }
    }