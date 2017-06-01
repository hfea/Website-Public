<a class="sr-only sr-only-focusable" href="#content">Skip to main content</a>
<nav class="navbar navbar-default">
  <div class="container">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header row">
        <div class="col-md-4">
            <a class="logo" href="/">
                <img src="/theme/assets/images/logos/Logo.png" alt="logo">
            </a>
        </div>
        <div class="col-md-4 text-center">
            <button type="button" class="navbar-toggle menu collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
        </div>
        <div class="col-md-4 text-right">
           <button type="button" class="navbar-toggle collapsed search" data-toggle="collapse" data-target="#navbar-form" aria-expanded="false">
                <span class="sr-only">Toggle search</span>
                <span class="glyphicon glyphicon-search"></span>

            </button>
        </div>
    </div>
    <form id="navbar-form" class="navbar-form navbar-left collapse" role="search">
        <div class="form-group">
            <input type="text" class="form-control" placeholder="Search">
        </div>
        <button type="submit" class="btn btn-default">Submit</button>
    </form>
    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <?php echo $bp->get_menu(); ?>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>
<div id="main-content">
    <?php if( ! $bp->is_home() ) { ?>
      <div class="container">
      <?php  echo $bp->get_breadcrumb(); ?>
    <?php } ?>
  <?php include $bp->get_node_template(); ?>
</div>
<?php $bp->get_sidebar(); ?>
<footer class="mt-100  p-20 container teal-bg">
  <ul class="list-inline ">
    <li>
      <a href="#">Freedom of information asfsdf </a>
    </li>
    <li>
      <a href="#">Privacy, Cookies & Terms </a>
    </li>
    <li>
      <a href="#">Accessibility</a>
    </li>
     <li>
      <a href="/about-us">About HFEA</a>
    </li>
  </ul>
</footer>
