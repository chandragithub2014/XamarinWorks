using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using XamarinPractice.ListMVVM.Model;
using XamarinPractice.model;

namespace XamarinPractice.ListMVVM.ViewModel
{
    public interface RetroInterface
    {
        [Get("/jly7p")]
        Task<List<Car>> GetCarDetails();
    }
}
