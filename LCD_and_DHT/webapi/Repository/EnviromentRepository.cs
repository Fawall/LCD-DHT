using System;
using System.Collections.Generic;
using webapi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Repository
{


    public class EnviromentRepository : IEnviroment
    {
        private readonly ProjectDBContext _context;

        public EnviromentRepository(ProjectDBContext projectDBContext)
        {
            _context = projectDBContext;
        }


        public async Task<EnviromentModel> CreateEnviromentState(float temperature, float humidity)
        {
            EnviromentModel env = new EnviromentModel(){
                Temperature = temperature,
                Humidity = humidity,
                Time = HrBrasilia()
            };

            await _context.Enviroment.AddAsync(env);
            await _context.SaveChangesAsync();

            return env;
        }
        public DateTime HrBrasilia()
        { 
            DateTime dateTime = DateTime.UtcNow;
            TimeZoneInfo hrBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, hrBrasilia);
        }
    }







}