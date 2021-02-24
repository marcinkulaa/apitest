using System;
using System.Collections.Generic;
using System.Text;

namespace testApi.TestData
{
    public class UserData
    {
        public static string JsonUserData = "[\r\n  {\r\n    \"name\": \"Test User\",\r\n    \"username\": \"Test\",\r\n    \"email\": \"test@test.test\",\r\n    \"address\": {\r\n      \"street\": \"KLight\",\r\n      \"suite\": \"556\",\r\n      \"city\": \"Krakow\",\r\n      \"zipcode\": \"99-999\",\r\n      \"geo\": {\r\n        \"lat\": \"-137.3159\",\r\n        \"lng\": \"181.1496\"\r\n      }\r\n    },\r\n    \"phone\": \"1-770-736-8031 x56442\",\r\n    \"website\": \"google.com\",\r\n    \"company\": {\r\n      \"name\": \"CompanyName\",\r\n      \"catchPhrase\": \"client-server api\",\r\n      \"bs\": \"This is Sparta\"\r\n    }\r\n  }\r\n]";
    }
}
