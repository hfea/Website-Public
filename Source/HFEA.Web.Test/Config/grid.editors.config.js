[
	{
	    "name": "Rich text editor",
	    "alias": "rte",
	    "view": "rte",
	    "icon": "icon-article"
	},
	{
	    "name": "Image",
	    "alias": "media",
	    "view": "media",
	    "icon": "icon-picture"
	},
	{
	    "name": "Macro",
	    "alias": "macro",
	    "view": "macro",
	    "icon": "icon-settings-alt"
	},
	{
	    "name": "Embed",
	    "alias": "embed",
	    "view": "embed",
	    "icon": "icon-movie-alt"
	},
    {
        "name": "Headline",
        "alias": "headline",
        "view": "textstring",
        "icon": "icon-coin",
        "config": {
			"style":"",
            "markup": "<h2>#value#</h2>"
        }
    },
	{
	    "name": "Paragraph",
	    "alias": "paragraph",
	    "view": "textstring",
	    "icon": "icon-list",
	    "config": {
			"style":"",
	        "markup": "<p>#value#</p>"
	    }
	},
	{
	    "name": "Header and Text spotlight",
	    "alias": "headerAndTextSpotlight",
	    "view": "/App_Plugins/HfeaGrid/editor.html",
	    "render": "/App_Plugins/HfeaGrid/render.cshtml",
	    "icon": "icon-checkbox-dotted"
	},
	{
	    "name": "Hyperlinked Header and Text spotlight",
	    "alias": "hyperlinkedHeaderAndTextSpotlight",
	    "view": "/App_Plugins/HfeaGrid/hyperlinkedEditor.html",
	    "render": "/App_Plugins/HfeaGrid/hyperlinkedRender.cshtml",
	    "icon": "icon-checkbox-dotted"
	},
	{
	    "name": "Header and Listing spotlight",
		"alias": "headerAndListingSpotlight",
		"view": "/app_plugins/HfeaGrid/listing-editor.html",
		"render": "/app_plugins/HfeaGrid/listing-render.cshtml",
	    "icon": "icon-checkbox-dotted"
	},
	{
	    "name": "Quote",
	    "alias": "quote",
	    "view": "textstring",
	    "icon": "icon-quote",
	    "config": {
			"style":"",
			"markup": "<section class='hfea-blockquote'><blockquote><p>#value#</p></blockquote></section>"
	    }
	},
    {
        "name": "News item",
        "alias": "newsItemPicker",
        "view": "/app_plugins/HfeaPopularPagesGrid/newsItemPicker.html",
        "icon": "icon-umb-developer color-orange"
    },
    {
        "name": "Generic item",
        "alias": "genericItemPicker",
        "view": "/app_plugins/HfeaPopularPagesGrid/genericItemPicker.html",
        "icon": "icon-umb-developer color-green"
    },
    {
        "name": "Generic item with image",
        "alias": "genericImageItemPicker",
        "view": "/app_plugins/HfeaPopularPagesGrid/genericImageItemPicker.html",
        "icon": "icon-umb-developer color-green"
    },
    {
        "name": "Event",
        "alias": "eventItemPicker",
        "view": "/app_plugins/HfeaPopularPagesGrid/eventItemPicker.html",
        "icon": "icon-umb-developer color-green"
    },
    {
        "name": "Informational block",
        "alias": "infoBlock",
        "view": "/app_plugins/HfeaPopularPagesGrid/infoBlock.html",
        "icon": "icon-umb-developer color-green"
    },
    {
        "name": "Content spotlight",
        "alias": "contentSpotlight",
        "view": "/app_plugins/HfeaListingPagesGrid/contentSpotlight.html",
        "icon": "icon-umb-developer color-blue"
    },
    {
        "name": "Text and image spotlight",
        "alias": "textAndImageSpotlight",
        "view": "/app_plugins/HfeaListingPagesGrid/textAndImageSpotlight.html",
        "icon": "icon-umb-developer color-red"
    },
    {
        "name": "Header and editor spotlight",
        "alias": "headerAndEditorSpotlight",
        "view": "/app_plugins/HfeaListingPagesGrid/headerAndEditorSpotlight.html",
        "icon": "icon-umb-developer color-red"
    },
    {
        "name": "Two column RTE spotlight",
        "alias": "twoColumnRichTextSpotlight",
        "view": "/app_plugins/HfeaListingPagesGrid/twoColumnRichTextSpotlight.html",
        "icon": "icon-umb-developer color-red"
    },
    {
        "name": "Framed header and text",
        "alias": "framedHeaderAndTextSpotlight",
        "view": "/app_plugins/HfeaListingPagesGrid/framedHeaderAndTextSpotlight.html",
        "icon": "icon-umb-developer color-red"
    }


    
]