using System.Collections.Generic;
using System.Reflection;
using ExtensionsServices.Implementation;
using Images.Implementation;
using Images.Interfaces;
using Images.Types;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.Configuration.App
{
    public class AppConfig
    {
        public static string ServerURL = "http://localhost:1030";

        public static void Setup()
        {
            SetupCatalogs();
            SetupAppImages("..\\..\\..\\Assets\\App\\");
            SetupDomainImages("..\\..\\..\\Assets\\Images\\");
        }

        private static void SetupCatalogs()
        {
            foreach (var prop in typeof(ObjectProvider).GetProperties())
            {
                prop.GetMethod.Invoke(null, null);
            }
        }

        private static void SetupAppImages(string prefix)
        {
            ServiceProvider.Images.SetAppImageSource(AppImageType.Load, prefix + "Load.png");
            ServiceProvider.Images.SetAppImageSource(AppImageType.Save, prefix + "Save.png");
            ServiceProvider.Images.SetAppImageSource(AppImageType.Quit, prefix + "Quit.png");
            ServiceProvider.Images.SetAppImageSource(AppImageType.Login, prefix + "Login.png");
            ServiceProvider.Images.SetAppImageSource(AppImageType.Image, prefix + "Image.png");
            ServiceProvider.Images.SetAppImageSource(AppImageType.NotFound, prefix + "NotSet.jpg.jpg");
            ServiceProvider.Images.SetAppImageSource(AppImageType.Logo, prefix + "Logo120x60.jpg");
        }

        private static void SetupDomainImages(string prefix)
        {
            List<IImage> imageList = new List<IImage>();

            #region Car image objects
            Image c1 = new Image("Red Sedan", prefix + "CarRedSedan.jpg");
            c1.AddTag("Car");
            c1.AddTag("Red");
            c1.AddTag("Sedan");
            c1.AddTag("Individual");

            Image c2 = new Image("Blue Combi", prefix + "CarBlueCombi.jpg");
            c2.AddTag("Car");
            c2.AddTag("Blue");
            c2.AddTag("Combi");
            c2.AddTag("Family");

            Image c3 = new Image("White Mini", prefix + "CarWhiteMini.jpg");
            c3.AddTag("Car");
            c3.AddTag("White");
            c3.AddTag("Mini");
            c3.AddTag("Family");

            Image c4 = new Image("Green Combi", prefix + "CarGreenCombi.jpg");
            c4.AddTag("Car");
            c4.AddTag("Green");
            c4.AddTag("Combi");
            c4.AddTag("Family");

            Image c5 = new Image("Purple Sport", prefix + "CarPurpleSport.jpg");
            c5.AddTag("Car");
            c5.AddTag("Purple");
            c5.AddTag("Sport");
            c5.AddTag("Family");

            Image c6 = new Image("Yellow Sport", prefix + "CarYellowSport.jpg");
            c6.AddTag("Car");
            c6.AddTag("Yellow");
            c6.AddTag("Sport");
            c6.AddTag("Individual");

            Image c7 = new Image("Black Sedan", prefix + "CarBlackSedan.jpg");
            c7.AddTag("Car");
            c7.AddTag("Black");
            c7.AddTag("Sedan");
            c7.AddTag("Family");

            Image c8 = new Image("Light Blue Combi", prefix + "CarLightBlueCombi.jpg");
            c8.AddTag("Car");
            c8.AddTag("Light Blue");
            c8.AddTag("Combi");
            c8.AddTag("Family");

            Image c9 = new Image("Magenta Pickup", prefix + "CarMagentaPickup.jpg");
            c9.AddTag("Car");
            c9.AddTag("Magenta");
            c9.AddTag("Pickup");
            c9.AddTag("Individual");

            imageList.Add(c1);
            imageList.Add(c2);
            imageList.Add(c3);
            imageList.Add(c4);
            imageList.Add(c5);
            imageList.Add(c6);
            imageList.Add(c7);
            imageList.Add(c8);
            imageList.Add(c9);
            #endregion

            #region Employee image objects
            Image s1 = new Image("Ann", prefix + "Ann.jpg");
            s1.AddTag("Employee");
            s1.AddTag("Female");

            Image s2 = new Image("Benny", prefix + "Benny.jpg");
            s2.AddTag("Employee");
            s2.AddTag("Male");

            Image s3 = new Image("Carol", prefix + "Carol.jpg");
            s3.AddTag("Employee");
            s3.AddTag("Female");

            Image s4 = new Image("Dan", prefix + "Dan.jpg");
            s4.AddTag("Employee");
            s4.AddTag("Male");

            Image s5 = new Image("Eliza", prefix + "Eliza.jpg");
            s5.AddTag("Employee");
            s5.AddTag("Female");

            imageList.Add(s1);
            imageList.Add(s2);
            imageList.Add(s3);
            imageList.Add(s4);
            imageList.Add(s5);
            #endregion

            #region Customer image objects
            Image cu1 = new Image("Allan", prefix + "Allan.png");
            cu1.AddTag("Customer");
            cu1.AddTag("Male");

            Image cu2 = new Image("Betty", prefix + "Betty.png");
            cu2.AddTag("Customer");
            cu2.AddTag("Female");

            Image cu3 = new Image("Carl", prefix + "Carl.png");
            cu3.AddTag("Customer");
            cu3.AddTag("Male");

            Image cu4 = new Image("Denice", prefix + "Denice.png");
            cu4.AddTag("Customer");
            cu4.AddTag("Female");

            Image cu5 = new Image("Eric", prefix + "Eric.png");
            cu5.AddTag("Customer");
            cu5.AddTag("Male");

            Image cu6 = new Image("Fiona", prefix + "Fiona.png");
            cu6.AddTag("Customer");
            cu6.AddTag("Female");

            imageList.Add(cu1);
            imageList.Add(cu2);
            imageList.Add(cu3);
            imageList.Add(cu4);
            imageList.Add(cu5);
            imageList.Add(cu6);
            #endregion

            ServiceProvider.Images.SetImages(imageList);
        }
    }
}