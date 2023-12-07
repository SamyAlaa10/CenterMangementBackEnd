using CenterMangement.Core.Entities;
using CenterMangement.Core.Specifications;
using CenterMangement.DTO.Entities.Account;
using CenterMangement.Repository.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.API
{
    public interface IControlBase
    {
        Task<design> Get<design, TableName>(long Id) where TableName : BaseEntity;
        Task<List<design>> Get<design, TableName>() where TableName : BaseEntity;
        Task<long> Add<designAdd, TableName>(designAdd Adder) where TableName : BaseEntity;
        Task<design> Update<designUbdate, TableName, design>(designUbdate Ubdater) where TableName : BaseEntity;
        Task Remove<TableName>(long Id) where TableName : BaseEntity;
        Task RemoveBySpec<TableName>(BaseSpecification<TableName> specification) where TableName : BaseEntity;
        Task<List<design>> GetAllBySpec<design, TableName>(BaseSpecification<TableName> specification ) where TableName : BaseEntity;
        Task<design> GetBySpec<design, TableName>( BaseSpecification<TableName> specification) where TableName : BaseEntity;
    }
}
