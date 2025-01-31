using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface ITimeTravel
    {
        public DateTime DT { get; set;}
    }
    public class TimeTravel : ITimeTravel
    {
        public DateTime DT { get; set; } = DateTime.Now;
    }
}