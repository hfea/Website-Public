<?php
$template = $twig->loadTemplate($bp->get_value('twig_template'));
echo $template->render($bp->get_value('data'));
