﻿using Hydra.Kernel.GeneralModels;
using Hydra.Common.Core.Models;

namespace Hydra.Common.Core.Interfaces
{
    public interface IDiscountService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns></returns>
        Task<Result<PaginatedList<DiscountModel>>> GetList(GridDataBound dataGrid);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Result<List<DiscountModel>>> GetListForSelect();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Result<DiscountModel>> GetById(int id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="discountModel"></param>
        /// <returns></returns>
        Task<Result<DiscountModel>> Add(DiscountModel discountModel);

        /// <summary>
        ///
        /// </summary>
        /// <param name="discountModel"></param>
        /// <returns></returns>
        Task<Result<DiscountModel>> Update(DiscountModel discountModel);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Result> Delete(int id);

    }
}