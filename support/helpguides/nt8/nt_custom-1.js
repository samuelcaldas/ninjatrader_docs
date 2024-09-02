$(document).ready(function() {
  addPermaLinks(); // adds the "permalink used for hot linking with a toggle expandedpmles

  toggleVideoTables(); //checks if there is a video table, hides it and adds onClick function to play  
});

addPermaLinks = function() {
  var url = document.URL;
  var splitUrl = url.split(/(\/)/);
  var pageName = splitUrl[splitUrl.length - 1];
  var togglerUrl = url.split(/(#)/);
  

  //if our pagename already has the #+toggle id, split the page name and replace with just the topic
  if (pageName.indexOf("#") > 1) {
    pageName = pageName.split("#")[0];
  }



  // remove ?zoom_highlightsub location if came from search
  if (pageName.indexOf("?zoom_highlightsub") > 1) {
  	pageName = pageName.split("?zoom_highlightsub")[0];
  }  

  $("#innerdiv").children().each(function(n, i) {

    var id = this.id;
    if (!id) return;

    $("#" + id).children("table").after('<div align="right" id="toggler_linker"><a href="' + "index.html?" + pageName + "#" + id + '" onClick="return false"><sub>permalink</sub> </a>');

    if (togglerUrl.length === 3) {
      var toggler = togglerUrl[2];
      if (id === toggler) {
        HMToggle("toggle", toggler, toggler + "_ICON");
      };
    }
  });
};

toggleVideoTables = function() {
  // find all videos
  $(".Video").each(function() {
    // on initial document load, hide the second row which contains the table
    $(this).find("tr:nth-child(2)").hide();
  });

  // play video image is in the first row
  $(".Video tr:nth-child(1) img").click(function() {
    // when clicked, find the next table row and toggle it on/off
    $(this).closest("tr").next("tr").toggle();
  });
};