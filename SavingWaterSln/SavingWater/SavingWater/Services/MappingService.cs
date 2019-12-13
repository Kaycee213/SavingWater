using Microsoft.EntityFrameworkCore.Storage;
using SavingWater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

/*namespace SavingWater.Services
{
    public class MappingService
    {
        public async Task<newLocation> GetCurrentLocation()
        {
            var noLocation = new newLocation();
            try
            {

                var loc = await Xamarin.Essentials.Geolocation.GetLocationAsync();
                var pins = await Geocoding.GetPlacemarksAsync(loc.Latitude, loc.Longitude);
                var firstPin = pins.FirstOrDefault();
                var myLocation = new newLocation(firstPin.SubLocality, firstPin.FeatureName, new Xamarin.Forms.Maps.Position(loc.Latitude, loc.Longitude));
                 {
                     Address = firstPin.SubLocality,
                     Description = firstPin.FeatureName,
                     Latitude = loc.Latitude,
                     Longitude = loc.Longitude
                 };
                return myLocation;
            }
            catch (FeatureNotEnabledException ex)
            {
                //await _pageDialogService.DisplayAlertAsync("Exception", "Please turn on your GPS location", "Ok");
                //return noLocation;
            }
        }
    }

   

}*/
