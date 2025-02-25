﻿using Hydra.Kernel.GeneralModels;

using Hydra.Order.Core.Models;

namespace Hydra.Order.Core.Interfaces
{
    public interface IShipmentItemService
    {

        /// <summary>
        ///
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns></returns>
        Task<Result<PaginatedList<ShipmentItemModel>>> GetList(GridDataBound dataGrid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Result<ShipmentItemModel>> GetById(int id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="shipmentItemModel"></param>
        /// <returns></returns>
        Task<Result<ShipmentItemModel>> Add(ShipmentItemModel shipmentItemModel);

        /// <summary>
        ///
        /// </summary>
        /// <param name="shipmentItemModel"></param>
        /// <returns></returns>
        Task<Result<ShipmentItemModel>> Update(ShipmentItemModel shipmentItemModel);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Result> Delete(int id);

    }
}