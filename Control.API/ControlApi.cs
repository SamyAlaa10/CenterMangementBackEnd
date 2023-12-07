using AutoMapper;
using CenterMangement.Core.Entities;
using CenterMangement.Core.Repostiories;
using CenterMangement.Core.Specifications;
using CenterMangement.DTO.Entities.Account;
using CenterMangement.Repository;
using CenterMangement.Repository.Specifications;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.API
{
    public class ControlApi : IControlBase
    {
        private readonly IUnitOfWork _IUnitOfWork;
        private readonly IMapper _Mapper;

        public ControlApi(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _IUnitOfWork = unitOfWork;
            _Mapper = mapper;
        }
        public async Task<G> Get<G, F>(long Id) where F : BaseEntity
        {
            var Item = await _IUnitOfWork.Repository<F>().GetByIdAsync(Id);
            var ItemDTO = _Mapper.Map<F, G>(Item);
            return ItemDTO;
        }

        public async Task<List<G>> Get<G, F>() where F : BaseEntity
        {
            var Item = await _IUnitOfWork.Repository<F>().GetAllAsynce();
            var ItemsDTO = _Mapper.Map<List<F>, List<G>>(Item.ToList());
            return ItemsDTO;
        }

        public async Task<long> Add<A, F>(A Adder) where F : BaseEntity
        {
            var itemA = _Mapper.Map<A, F>(Adder);
            await _IUnitOfWork.Repository<F>().AddAsync(itemA);
            await _IUnitOfWork.Complete();
            return itemA.Id;
        }

        public async Task<G> Update<U, F, G>(U Ubdater) where F : BaseEntity
        {
            var itemU = _Mapper.Map<U, F>(Ubdater);
            _IUnitOfWork.Repository<F>().Update(itemU);
            await _IUnitOfWork.Complete();
            var item = _Mapper.Map<F, G>(itemU);
            return item;
        }

        public async Task Remove<F>(long Id) where F : BaseEntity
        {
            var Item = await _IUnitOfWork.Repository<F>().GetByIdAsync(Id);
            _IUnitOfWork.Repository<F>().Delete(Item);
            await _IUnitOfWork.Complete();
        }
        public async Task RemoveBySpec<TableName>(BaseSpecification<TableName> specification) where TableName : BaseEntity
        {
            var Item = await _IUnitOfWork.Repository<TableName>().GetAllWithSpecAsynce(specification);
            _IUnitOfWork.Repository<TableName>().DeleteReange(Item);
            await _IUnitOfWork.Complete();
        }

        public async Task<List<design>> GetAllBySpec<design, TableName>(BaseSpecification<TableName> specification) where TableName : BaseEntity
        {
            var Item = await _IUnitOfWork.Repository<TableName>().GetAllWithSpecAsynce(specification);
            var ItemsDTO = _Mapper.Map<List<TableName>, List<design>>(Item.ToList());
            return ItemsDTO;
        }

        public async Task<design> GetBySpec<design, TableName>(BaseSpecification<TableName> specification) where TableName : BaseEntity
        {
            var Item = await _IUnitOfWork.Repository<TableName>().GetByIdWithSpecAsync(specification);
            var ItemDTO = _Mapper.Map<TableName, design>(Item);
            return ItemDTO;
        }
    }
}
