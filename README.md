#PingWeb
Windows tool to ping your website for checking availability and response time

### What is PingWeb?
PingWeb is a windows tool for repeatedly pinging a website URL to check availability and response time.

### How do I get started?
Run the PingWeb.exe file from App folder which displays below windows form. Enter your desired Request URL and set the desired configuration and Start the process.
![alt tag](https://cloud.githubusercontent.com/assets/6698586/16246396/f4a49578-37fc-11e6-81a7-fdd64897d3f8.PNG)
 
### Features
* "Delay" after each ping specified in seconds
* "TimeOut" in seconds is a maximum response waite time 
* "Response specific" enabling this and spcifiying the response will validate the response before marking the request as success
* "Save to database" (SqlLite) this will allow appication to save ping data in sqlLite database. Use Sql lite browser tool to read the data
* "Hide Data Grid" This would hide the data grid, this can be used for running the application continuesly and reduce system memory usage. Note that this feature will save the data in SqlLite database
* "Show Response" shows the response column in data grid. If the response is too large you can view the response by copying the cell and pasting it into notepad or any other editor.

### Where can I get it?
Downloading from git hub will include executable file PingWeb.exe in app folder and source code for visual studio.

### How can I get help?
Use the issues link to get in touch with me about any improvements that could be made, or any bugs you encounter.
