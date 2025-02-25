﻿using Hydra.Kernel.GeneralModels;

using Hydra.Common.Core.Models;

namespace Hydra.Common.Core.Interfaces
{
    public interface ISearchTermService
    {

        /// <summary>
        ///
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns></returns>
        Task<Result<PaginatedList<SearchTermModel>>> GetList(GridDataBound dataGrid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Result<SearchTermModel>> GetById(int id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="searchTermModel"></param>
        /// <returns></returns>
        Task<Result<SearchTermModel>> Add(SearchTermModel searchTermModel);

        /// <summary>
        ///
        /// </summary>
        /// <param name="searchTermModel"></param>
        /// <returns></returns>
        Task<Result<SearchTermModel>> Update(SearchTermModel searchTermModel);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Result> Delete(int id);

    }
}