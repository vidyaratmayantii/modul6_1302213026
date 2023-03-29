// See https://aka.ms/new-console-template for more information
using modul6_1302213026;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review film spiderman3 oleh vidya");
        SayaTubeVideo video2 = new SayaTubeVideo("Review film hulk oleh vidya");
        SayaTubeVideo video3 = new SayaTubeVideo("Review film titanic oleh vidya");
        SayaTubeVideo video4 = new SayaTubeVideo("Review film capten america oleh vidya");
        SayaTubeVideo video5 = new SayaTubeVideo("Review film spiderman2 oleh vidya");
        SayaTubeVideo video6 = new SayaTubeVideo("Review film spiderman1 oleh vidya");
        SayaTubeVideo video7 = new SayaTubeVideo("Review film iron man oleh vidya");
        SayaTubeVideo video8 = new SayaTubeVideo("Review film batman oleh vidya");
        SayaTubeVideo video9 = new SayaTubeVideo("Review film hotel transylvania oleh vidya");
        SayaTubeVideo video10 = new SayaTubeVideo("Review film rapunzel oleh vidya");

        video1.IncreasePlayCount(1);
        video1.PrintVideoDetail();

        video2.IncreasePlayCount(1);
        video2.PrintVideoDetail();

        video3.IncreasePlayCount(1);
        video3.PrintVideoDetail();

        video4.IncreasePlayCount(1);
        video4.PrintVideoDetail();

        video5.IncreasePlayCount(1);
        video5.PrintVideoDetail();

        video6.IncreasePlayCount(1);
        video6.PrintVideoDetail();

        video7.IncreasePlayCount(1);
        video7.PrintVideoDetail();

        video8.IncreasePlayCount(1);
        video8.PrintVideoDetail();

        video9.IncreasePlayCount(1);
        video9.PrintVideoDetail();

        video10.IncreasePlayCount(1);
        video10.PrintVideoDetail();
    }
}