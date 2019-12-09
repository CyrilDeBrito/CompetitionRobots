using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;
using System.Drawing;

namespace M1IL
{


    public class LAgiliste : AdvancedRobot
    {
        // The main method of your robot containing robot logics
        public override void Run()
        {
            // Perform your initialization for yout robot here
            BodyColor = (Color.Red);
            // Initialization of the robot

            // Here we turn the robot to point upwards, and move the gun 90 degrees
            TurnLeft(Heading - 90);
            TurnRight(90);

            // Infinite loop making sure this robot runs till the end of the battle round
            while (true)
            {
                // Perform robot here calling robot commands etc.

                // Comands that are repeated forever

                // Move our robot 5000 pixels ahead
                TurnRight(90);


                // Our robot will move along the borders of the battle fiels
                // by repeating the above two starements.
            }
        }

        //Robot event handler, when the robot sees another robot
        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            base.OnScannedRobot(evnt);
            // We fire the gun with bullet power = 1
            Fire(1);
        }
    }
}
