# Allwin.Sitecore.Modules.GoogleMaps

## 1. Module purpose ##

The Google Maps is a very popular feature a modern good website can have. The visitors who demand fast and easy access for the desired information dont want spend time for searching for them. Today just show the address on the page is simply not enough.  The ’How to get there?’ became such as inportant as the ’Where it is?’.

We choosed this module to integrate because we exprienced that most of the developers dont take care this too much. For smaller sites which have tipically one contact page with a map the settings are hardcoded or  for large companies the location data is stored in database. It doesn’t matter which way we choose, the customer is not able to edit the data even if he could do it.

More over the the Google Maps could be more just a simple tool. It is true it is a very complex application, but this complexity is the key to step over its common usages. Those lot of options allow us to customize the map, and create someting good looking, well designed element which adds some extra, positive inpact our page.  
So our main purpose is to get this tool and bring it to the customer, and of course release ourself of implementing the same element time by time.

Because there are hundreds of options and events to implement, today we focused on implementing a basic functionaly with a wide range of options to change the look of the map.

## 2. The structure ##

The templates can be found under the /sitecore/templates/Modules/Google Maps/Google Maps Settings folder. 

 1. _Maps : The very first item which has to be created. It is to hold the _GoogleMap items.
 2. _GoogleMap : It reprezents one map. It is the base datasource item for the module.
 3. _Markers : This is a container for the _MapMarker elements
 4. _MapMarker : It reprezents one marker on the map
 5. _Styles : This is a container for the _Style elements
 6. _Style : This is reprezent a style which can be added to the map. It defines which feature and/or type of an element of the map is styled with _Stylers
 7. _Styler: defines the particular value of the changes applied on an element, such as ’visibility’, ’hue’, ’saturation’ ...
 8. _DropdownValue: simple type to store predifined data for dorpdown

## 3. How to use the module? ##
[![YouTube Video](https://img.youtube.com/vi/ph7_K3pZb08/0.jpg)](https://www.youtube.com/watch?v=ph7_K3pZb08)
