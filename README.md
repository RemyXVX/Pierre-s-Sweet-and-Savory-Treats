# Pierre's Sweet and Savory Treats

#### By **Remy Flores**

#### **Pierre's Sweet and Savory Treats**

## Technologies Used
* VSCode
* GitBash
* C#
* .NET6 SDK
* WindowPowerShell
* Razor
* CSS
* HTML
* MySQL Server
* MySQL Workbench

## Description
_Ceating yet another web application for our favorite client Pierre. This time around we will be able to create accounts for Users to add, create, deleted snacks and organize them._

## Webpage
* [https://github.com/RemyXVX/Pierre-s-Sweet-and-Savory-Treats]

## Setup/Installation Requirements
* _Chrome web browser for best compatiblity_
* _Have a prompt and editor to apply changes, like VSCode and Gitbash_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here for VScode](https://code.visualstudio.com/download)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here for Gitbash](https://git-scm.com/downloads)

* _Installation of .Net 6.0 and C# for applied language_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

* _Aftward, download MySQL Server & Workbench_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Download here](https://dev.mysql.com/downloads/mysql/)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(more information on how to setup MySQL Server & Workbench, see [here](https://www.youtube.com/watch?v=u96rVINbAUI&ab_channel=WebDevSimplified))

* _From there download repo for **Dr. Sillystringz's Factory**_

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Copy here](https://github.com/RemyXVX/Pierre-s-Sweet-and-Savory-Treats)

## Step by step breakdown on how to run application: ##
<br>

<big>copy by running:</big>

```
git clone "[https://github.com/RemyXVX/Pierre-s-Sweet-and-Savory-Treats.git]"
````

<big>I would recommend also setting up your work envirnoment after cloning by:</big>

```
$dotnet build
```
<big>Once we have the program started, I would add an '_appsettings.json_' file like:</big>
```
$touch appsetting.json

and then add to the file:

{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

<big>Afterwards,</big>

```
$dotnet run
```

<big>Now we can double check for errors in our code.(Address each if errors if any appear.)<br>



## Known Bugs
* _It might not look pretty but it's functional. I also ran out of CocaCola. (please sponsor me!!)_

## License
* **SEE LICENSE [HERE](./LICENSE.txt)** 