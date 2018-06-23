# myheroAPI

My Hero List
By: Muhammad A Nadeem

Introduction 
‘My Hero List’ is a RESTful web service that contains information about my favourite heroes (still active or no longer active in their fields) of our global system. 

Just tap into My Hero List to learn about the heroes around us in the field of politics, sports, and philanthropy.  Great for quick and up-to-date information about few famous personalities! 

‘My Hero List’ will return information on few of my heroes in my list per API request. Results are in JSON format. 

Instructions 
Endpoint: http://myheroapi-nadeem.azurewebsites.net/ 

Using My-Hero-List requires knowing how to interpret query strings, use query string variables, and JSON formatting. 

Authorization is not required to use My-Hero-List as it is considered an open source. So no API key is needed. Supply the query string variable and value to the endpoint for each request in a format like http://myheroapi-nadeem.azurewebsites.net/GetHeroes?id=1

My-Hero-List will return the HTTP status code of 404 (if Azure service is not available) back to your application. My-Hero-List is in production so developers are welcome to use it. This is subject to change upon subsequent releases of My-Hero-List. 

There are two methods of querying the contents of My-hero-List expression. You may either search for hero by id or retrieve all heroes. Only one method may be used. If heroes are searched by id, My-Hero-List will retrieve results only by id associated with the hero. 

To retrieve a hero’s information by id, supply the 'id' query string value with an integer. This will return a JSON object of a hero's details. If integer supplied to 'id' does not correspond to an id, the returned JSON object will be empty. 

If only the query string variable is supplied without an id, then all heroes from My-Hero-List will be returned in a JSON array object.

Contact Questions/Comments/Complaints
Any and all inquiries should be emailed to nadeem133@hotmail.com. 


Terms of Use 
Developers may use My-Hero-List so long as they adhere to the contents of this Terms of Use. My-Hero-List may be used for education purposes only and must reference the following URL as a code comment: https://github.com/Nadeem133/myheroAPI

