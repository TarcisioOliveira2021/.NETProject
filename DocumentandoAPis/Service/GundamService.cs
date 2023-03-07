
namespace DocumentandoAPis.Service
{
    public static class GundamService
    {
        static List<Gundam> GundamList {get;}
        static int proximoId = 3;
        

        static GundamService(){
            GundamList = new List<Gundam>{
                new Gundam{
                    Id = 0,
                    Modelo = "ASW-G-008 Barbatos lupus",
                    Fabricante = "Teiwaz",
                    Operator = "Mikazuki Augus",
                    Height = 18,
                    FuelType= "Hydrogen",
                    FrameMaterial = "High Hardness Rare Alloy"
                    },
                
                new Gundam{
                    Id = 1,
                    Modelo = "AGE-2 Gundam ACE-2 Normal",
                    Fabricante = string.Empty,
                    Operator = "Earth Federation Forces",
                    Height = 18,
                    FuelType= string.Empty,
                    FrameMaterial = string.Empty
                    },

                new Gundam{
                    Id = 2,
                    Modelo = "XVX-016 Aerial Gundam",
                    Fabricante = "Shin sei Development Corp",
                    Operator = "Earth house",
                    Height = 18,
                    FuelType= string.Empty,
                    FrameMaterial = string.Empty
                    },
            };
        }

         public static List<Gundam> ObterTodosGundam() => GundamList;

         public static Gundam ObterGundam(int id) => GundamList.FirstOrDefault(g => g.Id == id);
        

        public static void AdicionarGundam(Gundam gundam){
            gundam.Id = proximoId++;
            GundamList.Add(gundam);
        }

        public static void RemoverGundam(int id){
            var gundamid = ObterGundam(id);
            if(gundamid is null){
               return;
            }
            GundamList.Remove(gundamid);
        }

        public static void UpdateGundam(Gundam gundam){
            var gundamAntigo = GundamList.FindIndex(g => g.Id == gundam.Id);
            if(gundamAntigo == -1)
                return;
            
            GundamList[gundamAntigo] = gundam;
        }

    }
}