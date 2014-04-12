using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nile.Core.Domain2.Users
{
    public class Address : BaseEntity2
    {
        /// <summary>
        /// （名）
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// （姓）
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 邮件
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// 省份/州
        /// </summary>
        public int? StateProvinceId { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public int? CityId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        ///区号
        /// </summary>
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// 电话号码(0731-00000000)
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        public string FaxNumber { get; set; }


        public object Clone()
        {
            return null;
            //var addr = new Address()
            //{
            //    FirstName = this.FirstName,
            //    LastName = this.LastName,
            //    Email = this.Email,
            //    Company = this.Company,
            //    Country = this.Country,
            //    CountryId = this.CountryId,
            //    StateProvince = this.StateProvince,
            //    StateProvinceId = this.StateProvinceId,
            //    City = this.City,
            //    Address1 = this.Address1,
            //    Address2 = this.Address2,
            //    ZipPostalCode = this.ZipPostalCode,
            //    PhoneNumber = this.PhoneNumber,
            //    FaxNumber = this.FaxNumber,
            //    CreatedOnUtc = this.CreatedOnUtc,
            //};
            // return addr;
        }
    }
}
