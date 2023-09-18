

/* $('.home-slide').slick({
	dots: true,
}); 

 var click = 'click';
$('.burgerbar').on(click, function(){

	if( !$(this).hasClass('open') ){ openMenu(); } 
	else { closeMenu(); }

});

function openMenu(){
	$('.circle').addClass('expand');
	$('.burgerbar').addClass('open');	
	$('.main-navigation').addClass('expand');
	$('#menu').addClass('show');
};

function closeMenu(){
	$('.circle').removeClass('expand');
	$('.burgerbar').removeClass('open');	
	$('.main-navigation').removeClass('expand');
	$('#menu').removeClass('show');
};

$('#menu a').on(click, function(){
	closeMenu();
});	

 $('.competence-list').on('click', '.competence-list_content', function() {
    $('.competence-list .competence-list_content.active').removeClass('active');
    $(this).addClass('active');
});
 
$('.services-slide').slick({
	dots: true,
	arrows: false,
});

$('.years').html(new Date().getFullYear());


//var docID = request.querystring();
const xhr = new XMLHttpRequest();
xhr.open("GET", "http://apiv2.trii.global/api/NewsArticles?apiKey=AKaKEb1SvCMzkaH7BXsIqpjdwN91MWYNWqBSIRH2oFfCq4DQA8RvD/oQ5twJl1yUTg==&projectCode=Proj006&languageID=en&page=1&totalRecord=6", true);

xhr.onload = function () {
	if (this.status === 200) {
		obj = JSON.parse(this.responseText);
		
		for (var i = 0; i < 6; i++ ){
			var title = obj[i].Title;
			var imgThumb = obj[i].WebThumbnail;
			//var date = obj[i].PublishedDate.split("T");		
			//var shortDesc = obj[i].ShortDescription;
			var id = obj[i].ID;
		
			$('#list-news' + i).html("<div class='news-card'>" + 
			"<a href='/v2/news-detail.html?docID="+ id +"'> <img src=' "+imgThumb+" ' class='img-responsive' alt='"+title+"'/> </a> "+
			" <div class='textNews'>" + 
			"<a href='/v2/news-detail.html?docID="+ id +"' class='ttl-news'>"+title+"</a> " //+ 
			//"<span>"+date[0]+"</span> " + 
			//"<div class='wider shortTeks'><p>"+shortDesc+"</p></div> " +
			//" <a href='/news-detail.html?docID="+ id +"' class='link-news'>Read More</a> </div></div>"+
			);
		}				
		
	}
	else {
		console.log("File not found");
	}
}
xhr.send();

*/