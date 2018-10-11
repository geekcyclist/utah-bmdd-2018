using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public static class States
    {
        // Refactoring ideas
        // - Apply Standard Naming
        // - Case Insensitive Comparison
        // - Switch to Dictionary - https://simpleprogrammer.com/pulling-out-the-switch-its-time-for-a-whooping/
        public static string chkState(string s)
        {
            string st = string.Empty;
            switch (s)
            {
                case "Alabama":
                    st = "AL";
                    break;
                case "Alaska":
                    st = "AK";
                    break;
                case "Arizona":
                    st = "AZ";
                    break;
                case "Arkansas":
                    st = "AR";
                    break;
                case "California":
                    st = "CA";
                    break;
                case "Colorado":
                    st = "CO";
                    break;
                case "Connecticut":
                    st = "CT";
                    break;
                case "Delaware":
                    st = "DE";
                    break;
                case "Florida":
                    st = "FL";
                    break;
                case "Georgia":
                    st = "GA";
                    break;
                case "Hawaii":
                    st = "HI";
                    break;
                case "Idaho":
                    st = "ID";
                    break;
                case "Illinois":
                    st = "IL";
                    break;
                case "Indiana":
                    st = "IN";
                    break;
                case "Iowa":
                    st = "IA";
                    break;
                case "Kansas":
                    st = "KS";
                    break;
                case "Kentucky":
                    st = "KY";
                    break;
                case "Louisiana":
                    st = "LA";
                    break;
                case "Maine":
                    st = "ME";
                    break;
                case "Maryland":
                    st = "MD";
                    break;
                case "Massachusetts":
                    st = "MA";
                    break;
                case "Michigan":
                    st = "MI";
                    break;
                case "Minnesota":
                    st = "MN";
                    break;
                case "Mississippi":
                    st = "MS";
                    break;
                case "Missouri":
                    st = "MO";
                    break;
                case "Montana":
                    st = "MT";
                    break;
                case "Nebraska":
                    st = "NE";
                    break;
                case "Nevada":
                    st = "NV";
                    break;
                case "New Hampshire":
                    st = "NH";
                    break;
                case "New Jersey":
                    st = "NJ";
                    break;
                case "New Mexico":
                    st = "NM";
                    break;
                case "New York":
                    st = "NY";
                    break;
                case "North Carolina":
                    st = "NC";
                    break;
                case "North Dakota":
                    st = "ND";
                    break;
                case "Ohio":
                    st = "OH";
                    break;
                case "Oklahoma":
                    st = "OK";
                    break;
                case "Oregon":
                    st = "OR";
                    break;
                case "Pennsylvania":
                    st = "PA";
                    break;
                case "Rhode Island":
                    st = "RI";
                    break;
                case "South Carolina":
                    st = "SC";
                    break;
                case "South Dakota":
                    st = "SD";
                    break;
                case "Tennessee":
                    st = "TN";
                    break;
                case "Texas":
                    st = "TX";
                    break;
                case "Utah":
                    st = "UT";
                    break;
                case "Vermont":
                    st = "VT";
                    break;
                case "Virginia":
                    st = "VA";
                    break;
                case "Washington":
                    st = "WA";
                    break;
                case "West Virginia":
                    st = "WV";
                    break;
                case "Wisconsin":
                    st = "WI";
                    break;
                case "Wyoming":
                    st = "WY";
                    break;
                case "American Samoa":
                    st = "AS";
                    break;
                case "District or Columbia":
                    st = "DC";
                    break;
                case "Federated States of Micronesia":
                    st = "FM";
                    break;
                case "Guam":
                    st = "GU";
                    break;
                case "Marshall Islands":
                    st = "MH";
                    break;
                case "Northern Mariana Islands":
                    st = "MP";
                    break;
                case "Palau":
                    st = "PW";
                    break;
                case "Puerto Rico":
                    st = "PR";
                    break;
                case "Virgin Islands":
                    st = "VI";
                    break;
                default:
                    st = string.Empty;
                    break;
            }
            return st;
        }
    }
}
