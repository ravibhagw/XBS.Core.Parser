﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XBS.Core.Parser
{
    public static class TeamNameHelper
    {
        public static string GetTeamAbbreviation(string teamName)
        {
            if (teamName == "Anaheim Ducks")
            {
                return "ANA";
            }
            else if (teamName == "Atlanta Flames")
            {
                return "ATL";
            }

            else if (teamName == "Minnesota North Stars")
            {
                return "MNS";
            }
            else if (teamName == "Arizona Coyotes")
            {
                return "ARI";
            }

            else if (teamName == "Quebec Nordiques")
            {
                return "QUE";
            }

            else if (teamName == "Team Canada")
            {
                return "CAN";
            }
            else if (teamName == "Team USA")
            {
                return "USA";
            }

            
            else if (teamName == "Boston Bruins")
            {
                return "BOS";
            }


            else if (teamName == "Buffalo Sabres")
            {
                return "BUF";
            }


            else if (teamName == "Carolina Hurricanes")
            {
                return "CAR";
            }


            else if (teamName == "Bay Area Seals/California Golden Seals")
            {
                return "CGS";
            }


            else if (teamName == "Calgary Flames")
            {
                return "CGY";
            }


            else if (teamName == "Chicago Blackhawks")
            {
                return "CHI";
            }


            else if (teamName == "Columbus Blue Jackets")
            {
                return "CBJ";
            }


            else if (teamName == "Cleveland Barons")
            {
                return "CLE";
            }


            else if (teamName == "Colorado Avalanche")
            {
                return "COL";
            }


            else if (teamName == "Dallas Stars")
            {
                return "DAL";
            }


            else if (teamName == "Detroit Red Wings")
            {
                return "DET";
            }


            else if (teamName == "Edmonton Oilers")
            {
                return "EDM";
            }


            else if (teamName == "Florida Panthers")
            {
                return "FLA";
            }


            else if (teamName == "Hamilton Tigers")
            {
                return "HAM";
            }


            else if (teamName == "Hartford Whalers")
            {
                return "HFD";
            }


            else if (teamName == "Kansas City Scouts")
            {
                return "KCS";
            }


            else if (teamName == "Los Angeles Kings")
            {
                return "LAK";
            }


            else if (teamName == "Minnesota Wild")
            {
                return "MIN";
            }


            else if (teamName == "Montreal Canadiens")
            {
                return "MTL";
            }


            else if (teamName == "Nashville Predators")
            {
                return "NSH";
            }


            else if (teamName == "New Jersey Devils")
            {
                return "NJ";
            }


            else if (teamName == "New York Islanders")
            {
                return "NYI";
            }


            else if (teamName == "New York Rangers")
            {
                return "NYR";
            }


            else if (teamName == "California Seals/Oakland Seals")
            {
                return "OAK";
            }


            else if (teamName == "Ottawa Senators")
            {
                return "OTT";
            }


            else if (teamName == "Philadelphia Flyers")
            {
                return "PHI";
            }


            else if (teamName == "Phoenix Coyotes")
            {
                return "PHX";
            }


            else if (teamName == "Pittsburgh Penguins")
            {
                return "PIT";
            }


            else if (teamName == "San Jose Sharks")
            {
                return "SJS";
            }


            else if (teamName == "St. Louis Blues")
            {
                return "STL";
            }


            else if (teamName == "Tampa Bay Lightning")
            {
                return "TBL";
            }


            else if (teamName == "Toronto Maple Leafs")
            {
                return "TOR";
            }


            else if (teamName == "Vancouver Canucks")
            {
                return "VAN";
            }


            else if (teamName == "Vegas Golden Knights")
            {
                return "VGK";
            }


            else if (teamName == "Winnipeg Jets")
            {
                return "WPG";
            }


            else if (teamName == "Washington Capitals")
            {
                return "WAS";
            }

            else if (teamName == "Seattle Kraken")
            {
                return "SEA";
            }

            return String.Empty;
        }

    }
}
