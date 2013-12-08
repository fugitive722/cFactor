using System;
using System.Collections.Generic;
using System.Json;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public class WebServiceRequest
	{
		private static WebServiceRequest _sharedRequest;

		private WebServiceRequest ()
		{
		}

		public static WebServiceRequest sharedRequest{ 
			get{
				if(_sharedRequest == null){

					_sharedRequest = new WebServiceRequest ();
				}
				return _sharedRequest;
			 }
		}

		public List<JObject> getCommunities (){
			//getActivityFeed ();
			//getBlogComments ();
			//getProfile ();
			//getCommunityResources ();
			//getCommunityResouceFolder ();
			//getCommunityResourceDocument ();
			//getCommunityMediaAlbums ();
			//getCommunityMediaAlbum ();
			getCommunityMediaItem ();

			// feeds 
			string feed1 = @"{ name : 'R&D',members:'25',blogPosts :'5',ideaPosts:'26',formPosts:'18',wikiPosts:'98', resources :'9', media:'75', ratingType:'thumsUp',ratingValue: '3',ratingGiven : 'true', image: 'image url', content: 'community json url' }";
			string feed2 = @"{ name : 'Get Fit cFactor',members:'468',blogPosts :'10',ideaPosts:'2',formPosts:'12',wikiPosts:'43', resources :'34', media:'132', ratingType:'thumsUp',ratingValue: '10',ratingGiven : 'false', image: 'image url', content: 'community json url' }";

			var first = JObject.Parse (feed1);
			var second = JObject.Parse (feed2);

			var r = new List<JObject> ();
			r.Add (first);
			r.Add (second);
			return r;
		}

		public JObject getCommunity(){
		
			string c = @"{ name:'R&D',description:'Come here to learn whats happening with the R&D team',thumbnailImage:'<thumbnailImageUrl>', coverImage:'coverImageUrl',member:'true',moderator:'true',administrator:'true', actions : [{name : 'Post Something', action : 'createBlogPost'},{name :'Ask a Question', action:'createForumPost'},{name:'Share an Idea', action: 'createIdeaPost'},{name:'Contribute to the Wiki',action:'createWikiTopic'},{name:'Upload a Document',action:'uploadDocument'},{name:'Upload Media',action:'uploadMedia'}], navigation : [{type:'webViewPortlets', name:'Home',icon:'images/icons/social.community.home.png',content:'<communityHomeJsonUrl>',selected:'true',includeFullHeader: 'true'},{type:'scroller', name:'Content',icon:'images/icons/social.community.content.png',content:'<communityContentJsonUrl>',includeFullHeader: 'false'},{type:'scroller', name:'People',icon:'images/icons/social.community.people.png',content:'<<communityPeopleJsonUrl>>',includeFullHeader: 'false'},{type:'scroller', name:'Spaces',icon:'images/icons/social.community.spaces.png',content:'<<communitySpacesJsonUrl>>',includeFullHeader: 'false'},{type:'scroller', name:'Administration',icon:'images/icons/social.community.administration.png',content:'<<communityAdministrationJsonUrl>>',includeFullHeader: 'false'},{type:'scroller', name:'Resources',icon:'images/icons/social.community.administration.png',content:'<<communityAdministrationJsonUrl>>',includeFullHeader: 'false'},{type:'scroller', name:'Medias',icon:'images/icons/social.community.administration.png',content:'<<communityAdministrationJsonUrl>>',includeFullHeader: 'false'}]}";
			var json = JObject.Parse (c);
			return json;
		
		}

		public List<JObject> getActivityFeed(){

			string one = @"{type:'blogPost',title:'What do you think of the app',summary:'""Well weve just launched the app and we want your opinion ',date:'Today',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'10',ratingAllowed:'true',commentCount:'2',content:'<communityBlogPostJsonUrl>'}";
			string two = @"{ type:'media',title:'Andrew Elchuk Uploaded 5 Media',summary:'<communityMediaThumbnail1Url>,<communityMediaThumbnail2Url>,<communityMediaThumbnail3Url>,<communityMediaThumbnail4Url>,<communityMediaThumbnail5Url>',date:'Today',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',content:'<communityMediaAlbumJsonUrl>'}";
			string three = @"{type:'endorsement',title:'Thanks Given',date:'1 Day Ago',summary:'Thanks for helping me figure out how to do merging in GIT!',endorsor:'Shey Shi',endorsorProfile:'<profileJsonUrl>',endorsorImage:'<profileImageUrl>',endorsee:'Shaun Schuler',endorseeProfile:'<profileJsonUrl>',endorseeImage:'<profileImageUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'5',ratingAllowed:'true',content:'<communityResourceItemJsonUrl>'}";
			string four = @"{type:'profileAttribute',title:'Updated Profile',date:'5 Days Ago',summary:'Update About Me',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>'}";
			string five = @"{type:'resources',title:'Counting',summary: 'A document about counting, starring the count, from Sesame Street', date :'16 Days Ago',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',}";


			var o = JObject.Parse (one);
			var tw = JObject.Parse (two);
			var th = JObject.Parse (three);
			var fo = JObject.Parse (four);
			var fi = JObject.Parse(five);

			var r = new List<JObject> ();
			r.Add (o);
			r.Add (tw);
			r.Add (th);
			r.Add (fo);
			r.Add (fi);

			return r;
		}

		public List<JObject> getBlogComments (){
			//string two = @"{type:'blogPost', title:'What do you think of the app', content:'<blogPostWebViewUrlOrHtml>', date:'September 9, 2013 11:04 am CST',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'10',ratingAllowed:'true',tags:[{1:'mobile',2:'app'}],tagAllowed:'true',commentCount:'2',commentAllowed:'true', comments:'<communityBlogCommentsJsonUrl>',actions:[{name:'Edit',action:'Edit'},{name:'Delete',action:'Delete'},{name:'Edit Tags',action:'editTags'},{name:'Lock',action:'Lock'},{name:'Feature',action:'Feature'},{name:'Report Inappropriate',action:'report'}]}";

			string one = @"{type:'blogComment', content:'<blogCommentWebViewUrlOrHtml>', date:'September 9, 2013 1:13 pm CST',author:'Shey Shi',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'1',ratingAllowed:'false',tags:[{1:'awesome'}],tagAllowed:'true',actions:[{name:'Edit',action:'Edit'},{name:'Delete',action:'Delete'},{name:'Edit Tags',action:'editTags'},{name:'Report Inappropriate',action:'report'}]}";
			string two = @"{type:'blogComment', content:'<blogCommentWebViewUrlOrHtml>', date:'September 9, 2013 11:30 am CST',author:'Shaun Schuler',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'0',ratingAllowed:'true',tags:[{}],tagAllowed:'true',actions:[{name:'Edit',action:'Edit'},{name:'Delete',action:'Delete'},{name:'Edit Tags',action:'editTags'},{name:'Report Inappropriate',action:'report'}]}";
			var o = JObject.Parse (one);
			var t = JObject.Parse (two);

			var r = new List<JObject> ();
			r.Add (o);
			r.Add (t);

			return r;
		}

		public JObject getProfile (){
		
			string one = @"{name:'Andrew Elchuk',details:['Programmer','cfactor','Saskatoon Office'],contact:[{type:'Email',value:'aelchuk@cfactorworks.com'},{type:'Phone',value:'306-652-5798 x112'}],thumbnailImage:'<thumbnailImageUrl>',coverImage:'<coverImageUrl>',myProfile:'true',navigation:[{type:'webViewPortlets',name:'Profile',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'},{type:'webViewPortlets',name:'Talent',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'},{type:'webViewPortlets',name:'Thanks',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'},{type:'webViewPortlets',name:'Activity',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'},{type:'webViewPortlets',name:'Following',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'},{type:'webViewPortlets',name:'Network',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'},{type:'webViewPortlets',name:'Communities',icon:'images/icons/social.profile.home.png',content:'<profileHomeJsonUrl>',selected:'true',includeFullHeader:'true'}]}";
			return JObject.Parse (one);

		}

		public JObject getCommunityResources(){
			string one = @"{feed :[{type:'resourceFolder',name:'Technical Specifications',content:'<communityResourceItemJsonUrl>',children:'<communityResourcesJsonUrl>'},{type:'resourceFolder',name:'Templates',content:'<communityResourceItemJsonUrl>',children:'<communityResourcesJsonUrl>',},{type:'resourceDocument',name:'Counting',content:'<communityResourceItemJsonUrl>'},{type:'createResourceFolder',name:'Create Folder'},{type:'uploadResourceDocument',name:'Upload Document'}]}";
			return JObject.Parse (one);
		}

		public JObject getCommunityResouceFolder (){
			string one = @"{type:'resourceFolder',title:'Technical Specifications',description:'This is where we will keep any technical spec documents.',date:'August 30, 2013 10:33 am CST', actions:[{name : 'Edit',action:'edit'},{name:'Delete',action:'delete'},{name:'Add Sub-Folder',action:'addFolder'},{name:'Upload New Document',action:'upload'}]}";
			return JObject.Parse (one);
		}

		public JObject getCommunityResourceDocument (){
			string one = @"{type:'resourceDocument',title:'Counting',description:'A document about counting, starring the count, from Sesame Street!',date:'September 1, 2013 10:33 am CST',download:'<documentDownloadUrl>',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'5',ratingAllowed:'true',tags:[{1: 'counting'}],tagAllowed:'true',actions:[{name:'Edit',action:'edit'},{name:'Delete',action:'delete'},{name:'Edit Tags',action:'editTags'},{name:'Lock',action:'lock'},{name:'Feature',action:'feature'},{name:'Report Inappropriate',action:'report'},{name:'Upload New Version',action:'upload'}]}";
			return JObject.Parse (one);
		}

		public JObject getCommunityMediaAlbums (){
		
			string one = @"{feed:[{type:'uploadMedia',name:'Upload Media'},{type:'mediaAlbum',name:'R&D Conference',content:'<communityMediaAlbumJsonUrl>'},{type:'mediaAlbum',name:'Miscellaneous',content:'<communityMediaAlbumJsonUrl>'}]}";
			return JObject.Parse (one);
		}

		public JObject getCommunityMediaAlbum (){
			string one = @"{name: 'R&D Conference',description:'Pictures from the R&D conference yesterday',actions:[{name:'Edit',action:'edit'},{name:'Delete',action:'delete'}],feed:[{type:'uploadMedia',name:'Upload Media'},{type:'mediaPhoto',name:'Meeting',content:'<communityMediaItemJsonUrl>'},{type:'mediaPhoto',name:'Lunch Time',content:'<communityMediaItemJsonUrl>'},{type:'mediaPhoto',name:'White Boarding Some Stuff',content:'<communityMediaItemJsonUrl>'},{type:'mediaVideo',name:'Summary Video',content:'<communityMediaItemJsonUrl>'}]}";
			return JObject.Parse (one);
		}

		public List<JObject> getCommunityMediaItem () {
			string one = @"{type:'mediaPhoto',title:'Lunch Time',description:'Mmm, pizza!',date:'September 9, 2013 12:30 pm CST',download:'<documentDownloadUrl>',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'1',ratingAllowed:'true',actions:[{name:'Edit',action:'edit'},{name:'Delete',action:'delete'},{name:'Edit Tags',action:'editTags'},{name:'Lock',action:'lock'},{name:'Feature',action:'feature'},{name:'Report Inappropriate',action:'report'},{name:'Upload New Version',action:'upload'}]}";
			var o = JObject.Parse (one);

			string two = @"{type:'mediaPhoto',title:'Lunch Time',description:'Mmm, pizza!',date:'September 9, 2013 12:30 pm CST',download:'<documentDownloadUrl>',author:'Andrew Elchuk',authorProfile:'<profileJsonUrl>',authorImage:'<profileImageUrl>',ratingType:'thumbsUp',ratingValue:'2',ratingAllowed:'true',actions:[{name:'Edit',action:'edit'},{name:'Delete',action:'delete'},{name:'Edit Tags',action:'editTags'},{name:'Lock',action:'lock'},{name:'Feature',action:'feature'},{name:'Report Inappropriate',action:'report'},{name:'Upload New Version',action:'upload'}]}";
			var t =  JObject.Parse (two);

			var r = new List<JObject> ();
			r.Add (o);
			r.Add (t);

			return r;

		}
	}

}

