using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using CardCapture.Models;

namespace CardCapture.Controllers
{
    public class ImportController : Controller
    {
        private readonly CardCaptureContext _context;

        public ImportController(CardCaptureContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync(string cardName)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
          //  client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("http://private-anon-164aaf62b9-yugiohprices.apiary-mock.com/api/card_data/" + cardName);

            var msg = await stringTask;
            // Console.Write(msg);

            ViewBag.JsonData = msg;

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiData>(msg);


            if (_context.Card.Any(t => t.Name != data.Data.Name))
            {
                _context.Add(data.Data);
                await _context.SaveChangesAsync();
            }
            return View(data);
        }
    }
}