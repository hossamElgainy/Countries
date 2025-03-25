using CountryData.Standard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Countries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult GetCountries()
        {
            var helper = new CountryHelper();
            return Ok(helper.GetCountries());
        }
        [HttpGet("[action]")]
        public IActionResult GetCountryData()
        {
            var helper = new CountryHelper();
            return Ok(helper.GetCountryData());
        }
        [HttpGet("[action]")]
        public IActionResult GetCountryByCode(string code)
        {
            var helper = new CountryHelper();
            return Ok(helper.GetCountryByCode(code));
        }
        [HttpGet("[action]")]
        public IActionResult GetCountryByCurrencyCode(string code)
        {
            var helper = new CountryHelper();
            return Ok(helper.GetCountryByCurrencyCode(code));
        }
        [HttpGet("[action]")]
        public IActionResult GetCountryByPhoneCode(string code)
        {
            var helper = new CountryHelper();
            return Ok(helper.GetCountryByPhoneCode(code));
        }
        [HttpGet("[action]")]
        public IActionResult GetCountryEmojiFlag(string code)
        {
            var helper = new CountryHelper();

            return Ok(helper.GetCountryEmojiFlag(code));

        }[HttpGet("[action]")]
        public IActionResult GetCurrencyCodesByCountryCode(string code)
        {
            var helper = new CountryHelper();
            return Ok(helper.GetCurrencyCodesByCountryCode(code));
        }
        [HttpGet("[action]")]
        public IActionResult GetPhoneCodeByCountryShortCode(string code)
        {
            var helper = new CountryHelper();

            return Ok(helper.GetPhoneCodeByCountryShortCode(code));
        }
        [HttpGet("[action]")]
        public IActionResult GetRegionByCountryCode(string code)
        {
            var helper = new CountryHelper();

            return Ok(helper.GetRegionByCountryCode(code));
        }
    }
}
