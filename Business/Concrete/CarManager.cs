using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Eco.Ocl.Impl;
using Entities.Concrete;
using Entities.DTOs;
using Salesforce.Common.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorResult = Core.Utilities.Results.ErrorResult;
using Business.Constants;
using Messages = Business.Constants.Messages;


namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {

            //İş kodları 

            if(car.Description.Length < 2 && car.DailyPrice < 0)
            {
                return new ErrorResult(Messages.ProductNameInvalid); 
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);






        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Car>> GetCarByPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }

       
    }
}
