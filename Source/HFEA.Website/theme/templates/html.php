<!doctype html>
<html lang="en" class="">
  <head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title><?php echo $bp->get_title() . ' | ' . $site_name; ?></title>
    <link rel="shortcut icon" href="/favicon.ico" />
    <!-- Bootstrap -->
    <link href="/theme/assets/css/bootstrap.css" rel="stylesheet">
    <link href="/theme/assets/css/bootstrap-tagsinput.css" rel="stylesheet">
    <link rel="stylesheet" href="/theme/assets/fonts/font-awesome/css/font-awesome.min.css">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <script>(function(H){H.className=H.className.replace(/\bno-js\b/,'js')}(document.documentElement))</script>

    <script type="text/javascript">
      WebFontConfig = { fontdeck: { id: '61095' } };

      (function() {
        var wf = document.createElement('script');
        wf.src = ('https:' == document.location.protocol ? 'https' : 'http') +
        '://ajax.googleapis.com/ajax/libs/webfont/1/webfont.js';
        wf.type = 'text/javascript';
        wf.async = 'true';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(wf, s);
      })();
    </script>
  </head>
  <body class="html <?php echo $bp->get_body_classes(); ?>">
    <div class="page">
      <?php include $bp->get_page_template(); ?>
    </div><!-- /.page -->
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <!-- <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script> -->
    <!-- Include all compiled plugins (below), or include individual files as needed -->

    <script src="/theme/assets/js/jquery-1.10.2.min.js"></script>
    <script src="/theme/assets/js/bootstrap.min.js"></script>
    <script src="/theme/assets/js/plugins.js" ></script>
    <script src="/theme/assets/js/hfea.js"></script>
    <script src="/theme/assets/js/prototype-only.js"></script>

    <script src="https://maps.googleapis.com/maps/api/js"></script>
  </body>
</html>
