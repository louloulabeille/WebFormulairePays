//jQuery(document).ready(function () {
function ValidText(source, args) {
    //var pattern = /^[a-zA-Z]{4,255}$/;
    var rgex = new RegExp(/^[a-zA-Z]{4,255}$/g);
    args.IsValid = false;

    if ( rgex.test( args.Value ) ) {
        args.IsValid = true;
    }
};
//});