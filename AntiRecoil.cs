using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacKillerRust
{
    public static class AntiRecoil
    {
        public static void Run()
        {
            var R1 = new Random(Guid.NewGuid().GetHashCode());

            while (true)
            {
                if (Main.CheatEnabled)
                {
                    if (InputHandler.IsKeyDown(Keys.LButton) && InputHandler.IsKeyDown(Keys.RButton))
                    {
                        switch (Main.CurrentWeapon.Mode)
                        {
                            case FiringMode.Automatic:
                                if (InputHandler.IsKeyDown(Keys.LButton) && InputHandler.IsKeyDown(Keys.RButton))
                                {
                                    if (!InputHandler.IsKeyDown(Keys.LButton)) break;

                                    for (var currentShotIndex = 0; currentShotIndex < Main.CurrentWeapon.RecoilTable.Length; currentShotIndex++)
                                    {
                                        if (!InputHandler.IsKeyDown(Keys.LButton)) break;
                                        double nextShotX = Main.CurrentWeapon.RecoilTable[currentShotIndex][0] * Main.CurrentWeapon.MovementMultiplier;
                                        double nextShotY = Main.CurrentWeapon.RecoilTable[currentShotIndex][1] * Main.CurrentWeapon.MovementMultiplier;

                                        double smoothedShotX = nextShotX / Main.CurrentWeapon.SmoothValue;
                                        double smoothedShotY = nextShotY / Main.CurrentWeapon.SmoothValue;

                                        for (int i = 0; i <= Main.CurrentWeapon.SmoothValue; i++)
                                        {
                                            InputHandler.RelativeMove((int)smoothedShotX, (int)smoothedShotY);
                                            Thread.Sleep(Main.CurrentWeapon.FireRate / Main.CurrentWeapon.SmoothValue);
                                        }

                                        /*
                                        InputHandler.RelativeMove(
                                            (int)Math.Round(Main.CurrentWeapon.RecoilTable[currentShotIndex][0] * Main.CurrentWeapon.MovementMultiplier, 0) / Main.CurrentWeapon.SmoothValue, 
                                            (int)Math.Round(Main.CurrentWeapon.RecoilTable[currentShotIndex][1] * Main.CurrentWeapon.MovementMultiplier, 0) / Main.CurrentWeapon.SmoothValue);
                                            */

                                        //Thread.Sleep(Main.CurrentWeapon.FireRate);
                                    }

                                }
                                else if (InputHandler.IsKeyDown(Keys.LButton) && InputHandler.IsKeyDown(Keys.RButton) && InputHandler.IsKeyDown((Keys)162))
                                {
                                    Console.WriteLine("Success");
                                }
                                break;
                            case FiringMode.SemiAutomatic:
                                while (InputHandler.IsKeyDown(Keys.LButton) && InputHandler.IsKeyDown(Keys.RButton))
                                {
                                    if (!InputHandler.IsKeyDown(Keys.LButton) && !InputHandler.IsKeyDown(Keys.RButton)) break;

                                    switch (Main.CurrentWeapon.Name)
                                    {
                                        case "Semi Automatic Rifle":
                                            InputHandler.RelativeMove(0, (int)Math.Round(55 * Main.CurrentWeapon.MovementMultiplier, 0));
                                            break;
                                        case "M92":
                                            InputHandler.RelativeMove(0, (int)Math.Round(45 * Main.CurrentWeapon.MovementMultiplier, 0));
                                            break;
                                        case "Python":
                                            InputHandler.RelativeMove(0, (int)Math.Round(96 * Main.CurrentWeapon.MovementMultiplier, 0));
                                            break;
                                        case "M39":
                                            InputHandler.RelativeMove(0, (int)Math.Round(50 * Main.CurrentWeapon.MovementMultiplier, 0));
                                            break;
                                        default:
                                            break;
                                    }

                                    InputHandler.KeyPress(0x22, Main.CurrentWeapon.FireRate);
                                    Thread.Sleep(Main.CurrentWeapon.FireRate);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
