function htmlEscape(str) {
    return str
        .replace(/&/g, '&amp;')
        .replace(/"/g, '&quot;')
        .replace(/'/g, '&#39;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;');
}

function htmlUnescape(str) {
    return str
        .replace(/&quot;/g, '"')
        .replace(/&#39;/g, "'")
        .replace(/&lt;/g, '<')
        .replace(/&gt;/g, '>')
        .replace(/&amp;/g, '&');
}

function isEmptyObject(obj) {
    if (isSet(obj)) {
        if (obj.length && obj.length > 0) {
            return false;
        }

        for (var key in obj) {
            if (hasOwnProperty.call(obj, key)) {
                return false;
            }
        }
    }
    return true;
};

function isSet(val) { return ((val != undefined) && (val != null)); }

function initMap(mapModel, id, askForGeolocation, options)
{
    var map;
    var center;

    var model = JSON.parse(htmlUnescape(mapModel));

    //var model = JSON.parse($("<textarea/>").html(mapModel).text());

    if (askForGeolocation) {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function(position){
                center =  new google.maps.LatLng( position.coords.latitude, position.coords.longitude)
                map.setCenter( center);
            });
        }
        else {
            x.innerHTML = "Geolocation is not supported by this browser.";
        }
    }

    options.mapTypeControlOptions = {
        mapTypeIds: ['roadmap', 'satellite', 'hybrid', 'terrain',
                'styled_map']
    };

    if (isEmptyObject(options.center))
    {
        options.center = null;
    }

    map = new google.maps.Map(document.getElementById("map-" + id), options);

    for (var i = 0, len = model.Markers.length; i < len; i++) {

        let marker = model.Markers[i];
        let markerMap = new google.maps.Marker({
            map: map,
            title: marker.MarkerOptions.Name,
            icon: marker.MarkerOptions.Icon,
            position:  new google.maps.LatLng( marker.MarkerOptions.PositionLatitude, marker.MarkerOptions.PositionLongitude)
        });

        if (marker.MarkerOptions.Icon)
        {
            markerMap.setIcon = marker.MarkerOptions.Icon;
        }

        if (marker.MarkerOptions.UseInfoWindow)
        {
            let infowindow = new google.maps.InfoWindow({
                content: marker.MarkerOptions.Content
            });

            markerMap.addListener('click', function() {
                infowindow.open(map,markerMap);
            });
        }
    }

    if (model.StylesAsJson)
    {
        var styles = new google.maps.StyledMapType(eval(model.StylesAsJson));
        styles.name ='Styled map';
        map.mapTypes.set('styled_map', styles);
        //map.setMapTypeId(options.mapTypeId);
        map.setMapTypeId('styled_map');
    }else
    {
        map.setMapTypeId(options.mapTypeId);
    }
}
