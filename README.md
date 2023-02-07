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
* ASPNetCore
* Identity

## Description
_Ceating yet another web application for our favorite client Pierre. This time around we will be able to create accounts for Users to add, create, deleted snacks and organize them. ALl is done only when they are login._

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

* _From there download repo for_ **Pierre's Sweet and Savory Treats**

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Copy here](https://github.com/RemyXVX/Pierre-s-Sweet-and-Savory-Treats)

## Step by step breakdown on how to run application:

<big>copy by running:</big>

```
git clone "[https://github.com/RemyXVX/Pierre-s-Sweet-and-Savory-Treats.git]"
````

<big>I would recommend also setting up your work envirnoment after cloning by:</big>

```
$dotnet build
```
<big>Once we have the program started, I would add an '<strong>appsettings.json</strong>' file like:</big>
```
$touch appsetting.json
```
<big>and then add to the file:</big>
```
{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
## Import the Database: ##
* _Open MySQL Workbench and find the Navigator pane_

* _Select "_<strong>Data Import/Restore</strong>_", which opens Data Import page._

* _Select the option labeled "_<strong>Import from Self Contained File</strong>_". Navigate to the top level of directory of files you downloaded from this repository ("_<strong>sweetsavory</strong>_")._

* _Within "_<strong>sweetsavory</strong>_", select the file named_ <strong>sweetsavory.sql</strong>

* _Underneath "_<strong>Default Schemijoia to be Imported To</strong>_", click the "_<strong>New...</strong>_" button, input the database name_ <strong>sweetsavory.sql</strong>_, and click "_<strong>OK</strong>_"._

* _Go to the "_<strong>Start Import</strong>_" button in the lower right corner of the Data Import Pane._

* _On the Navigator panel, select the "_<strong>Schemas</strong>_" tab. Click the "_<strong>refresh</strong>_" icon (two arrows arranged in a circle in the top right corner of the pane), and the database should appear._

<big>Afterwards:</big>

```
$dotnet watch run
```

<big>Now we can double check for errors in our code. (Address each if errors if any appear.)</big><br>

## Known Bugs
* _It might not look pretty but it's functional. <strike>I also ran out ofCocaCola. (please sponsor me!!)</strike> (Offically off the juice)_
* _If I missed something, or a bug is found send me an email to_ remyfranciscoflores@gmail.com

## License
* **SEE LICENSE [HERE](./LICENSE.txt)** 