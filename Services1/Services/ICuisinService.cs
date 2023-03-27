using FormationMVC.Models.DTO;
using System.Collections.Generic;

namespace FormationMVC.Models.Abstracts
{
    public interface ICuisinService
    {
        List<Cuisin> GetAllCuisin();
         void AddCuisin(Cuisin cuisin);
      void RemoveCuisin(string Name);
         void UpdateCuisin(string Name);
         void DeleteCuisin(string Name);
        Cuisin GetCuisin(string Name);
    }
}
