@Code
    ViewData("Title") = "Home Page"
    Layout = "~/Views/_LayoutPage1.vbhtml"
End Code

<!doctype html>
<html lang="en">

<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Google fonts -->
    <link href="//fonts.googleapis.com/css2?family=Ubuntu:wght@300;400;500;700&display=swap" rel="stylesheet">
    <!-- Template CSS Style link -->
    <link rel="stylesheet" href="~/assets/css/style-starter.css">
</head>

<body>
    <!-- banner section -->
    <section id="home" class="w3l-banner py-5">
        <div class="banner-content">
            <div class="container py-4">
                <div class="row align-items-center pt-sm-5 pt-4">
                    <div class="col-md-6">
                        <h3 class="mb-lg-4 mb-3">
                            Multi -<span class="d-block">Language Course</span>
                        </h3>
                        <p class="banner-sub">The free, fun, and effective way to learn a language!</p>
                        <div class="d-flex align-items-center buttons-banner">
                            <a href="/Home/Register" class="btn btn-style mt-lg-5 mt-4">Join Us</a>
                            <a href="/Home/Login" class="btn btn-style2 mt-lg-5 mt-4">Log in</a>
                        </div>
                    </div>
                    <div class="col-md-6 right-banner-2 text-end position-relative mt-md-0 mt-5">
                        <div class="sub-banner-image mx-auto">
                            <img src="~/assets/images/banner.png" class="img-fluid position-relative" alt=" ">
                        </div>
                        <div class="banner-style-1 position-absolute">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- //banner section -->
    <!-- home 4grids block -->
    <section class="services-w3l-block py-5" id="features">
        <div class="container py-md-5 py-4">
            <div class="title-main text-center mx-auto mb-md-5 mb-4" style="max-width:500px;">
                <p class="text-uppercase">Best Features</p>
                <h3 class="title-style">Achieve Your Goals With U-Learn</h3>
            </div>
            <div class="row">
                <div class="col-md-6 col-lg-3 d-flex align-items-stretch">
                    <div class="icon-box icon-box-clr-1">
                        <div class="icon"><i class="fas fa-user-friends"></i></div>
                        <h4 class="title"><a href="#about">Effective and efficient</a></h4>
                        <p>Learn Language effectively dan efficiently through our courses </p>
                    </div>
                </div>
                <div class="col-md-6 col-lg-3 d-flex align-items-stretch mt-md-0 mt-4">
                    <div class="icon-box icon-box-clr-2">
                        <div class="icon"><i class="fas fa-book-reader"></i></div>
                        <h4 class="title"><a href="#about">Quality Education</a></h4>
                        <p>Ras effic itur metusga via suscipit consect eturerse adi unde omnis.</p>
                    </div>
                </div>
                <div class="col-md-6 col-lg-3 d-flex align-items-stretch mt-lg-0 mt-4">
                    <div class="icon-box icon-box-clr-3">
                        <div class="icon"><i class="fas fa-user-friends"></i></div>
                        <h4 class="title"><a href="#about">Personalized learning</a></h4>
                        <p>lessons are tailored to help you learn at just the right level and pace.</p>
                    </div>
                </div>
                <div class="col-md-6 col-lg-3 d-flex align-items-stretch mt-lg-0 mt-4">
                    <div class="icon-box icon-box-clr-4">
                        <div class="icon"><i class="fas fa-university"></i></div>
                        <h4 class="title"><a href="#about">Stay motivated</a></h4>
                        <p>We make it easy to form a habit of language learning, with game-like features, fun challenges</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- home 4grids block -->
    <!-- home image with content block -->
    <section class="w3l-servicesblock pt-lg-5 pt-4 pb-5 mb-lg-5" id="about">
        <div class="container pb-md-5 pb-4">
            <div class="row pb-xl-5 align-items-center">
                <div class="col-lg-6 position-relative home-block-3-left pb-lg-0 pb-5">
                    <div class="position-relative">
                        <img src="~/assets/images/img1.jpg" alt="" class="img-fluid radius-image">
                    </div>
                    <div class="imginfo__box">
                        <h6 class="imginfo__title">Join Us Now</h6>
                        <p>Now with over 10+<br>  Language courses available!</p>
                    </div>
                </div>
                <div class="col-xl-5 col-lg-6 offset-xl-1 mt-lg-0 mt-5 pt-lg-0 pt-5">
                    <h3 class="title-style">We Are The Best Choice For Learning Languages</h3>
                    <p class="mt-4">
                        Lorem ipsum viverra feugiat. Pellen tesque libero ut justo,
                        ultrices in ligula. Semper at tempufddfel. Lorem ipsum dolor sit amet consectetur adipisicing
                        elit.
                    </p>
                    <ul class="mt-4 list-style-lis pt-lg-1">
                        <li><i class="fas fa-check-circle"></i>Special Education</li>
                        <li><i class="fas fa-check-circle"></i>Access more than 10+ online language courses</li>
                        <li><i class="fas fa-check-circle"></i>Traditional Academies</li>
                    </ul>
                    <a href="/Home/Register" class="btn btn-style mt-5">Apply Now</a>
                </div>
            </div>
        </div>
    </section>
    <!-- //home image with content block -->
    <!-- courses section -->
    <div class="w3l-grids-block-5 home-course-bg py-5" id="courses">
        <div class="container py-md-5 py-4">
            <div class="title-main text-center mx-auto mb-md-5 mb-4" style="max-width:500px;">
                <p class="text-uppercase">Best Courses</p>
                <h3 class="title-style">Find The Right Language Course For You</h3>
            </div>
            <div class="row justify-content-center">
                <div class="col-lg-4 col-md-6">
                    <div class="coursecard-single">
                        <div class="grids5-info position-relative">
                            <img src="~/assets/images/c1.jpg" alt="" class="img-fluid" />
                            <div class="meta-list">
                                <a href="courses.html">Italian</a>
                            </div>
                        </div>
                        <div class="content-main-top">
                            <div class="content-top mb-4 mt-3">
                                <ul class="list-unstyled d-flex align-items-center justify-content-between">
                                    <li> <i class="fas fa-book-open"></i> 43 Lesson</li>
                                    <li> <i class="fas fa-star"></i> 4.5</li>
                                </ul>
                            </div>
                            <h4><a href="courses.html">Italian Language</a></h4>
                            <p>Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                            <div class="top-content-border d-flex align-items-center justify-content-between mt-4 pt-4">
                                <h6>Free</h6>
                                <a class="btn btn-style-primary" href="courses.html">
                                    Know Details<i class="fas fa-arrow-right"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 mt-md-0 mt-4">
                    <div class="coursecard-single">
                        <div class="grids5-info position-relative">
                            <img src="~/assets/images/c2.jpg" alt="" class="img-fluid" />
                            <div class="meta-list">
                                <a href="courses.html" class="sec-2">Chinese</a>
                            </div>
                        </div>
                        <div class="content-main-top">
                            <div class="content-top mb-4 mt-3">
                                <ul class="list-unstyled d-flex align-items-center justify-content-between">
                                    <li> <i class="fas fa-book-open"></i> 72 Lesson</li>
                                    <li> <i class="fas fa-star"></i> 4.3</li>
                                </ul>
                            </div>
                            <h4><a href="courses.html">Chinese Hanzhi and PinYin Cources</a></h4>
                            <p>Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                            <div class="top-content-border d-flex align-items-center justify-content-between mt-4 pt-4">
                                <h6>Free</h6>
                                <a class="btn btn-style-primary" href="courses.html">
                                    Know Details<i class="fas fa-arrow-right"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 mt-lg-0 mt-4">
                    <div class="coursecard-single">
                        <div class="grids5-info position-relative">
                            <img src="~/assets/images/c3.jpg" alt="" class="img-fluid" />
                            <div class="meta-list">
                                <a href="courses.html" class="sec-3">Korean</a>
                            </div>
                        </div>
                        <div class="content-main-top">
                            <div class="content-top mb-4 mt-3">
                                <ul class="list-unstyled d-flex align-items-center justify-content-between">
                                    <li> <i class="fas fa-book-open"></i> 14 Lesson</li>
                                    <li> <i class="fas fa-star"></i> 4.2</li>
                                </ul>
                            </div>
                            <h4><a href="courses.html">Korean hangul Cources</a></h4>
                            <p>Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                            <div class="top-content-border d-flex align-items-center justify-content-between mt-4 pt-4">
                                <h6>Free</h6>
                                <a class="btn btn-style-primary" href="courses.html">
                                    Know Details<i class="fas fa-arrow-right"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="text-center mt-sm-5 mt-4 pt-sm-0 pt-1">
                <a class="btn btn-style btn-style-secondary mt-sm-3" href="/Home/Courses">
                    Browse more courses
                </a>
            </div>
        </div>
    </div>
    <!-- //courses section -->
    
    <!-- blog block -->
    <div class="w3l-blog-block-5 py-5" id="blog">
        <div class="container py-md-5 py-4">
            <div class="title-main text-center mx-auto mb-md-5 mb-4" style="max-width:500px;">
                <p class="text-uppercase">Our News</p>
                <h3 class="title-style">Latest <span>Blog</span> Posts</h3>
            </div>
            <div class="row justify-content-center">
                <div class="col-lg-4 col-md-6">
                    <div class="blog-card-single">
                        <div class="grids5-info">
                            <a href="#blog"><img src="~/assets/images/blog2.jpg" alt="" /></a>
                            <div class="blog-info">
                                <h4><a href="#blog">Your Japanese Course...</a></h4>
                                <p>
                                    I find it very easy to learn japanese through your japanese course,10/10 would recomend.
                                </p>
                                <div class="d-flex align-items-center justify-content-between mt-4">
                                    <a class="d-flex align-items-center" href="#blog" title="23k followers">
                                        <img class="img-fluid" src="~/assets/images/testi2.jpg" alt="admin"
                                             style="max-width:40px"> <span class="small ms-2">Eetey Cruis</span>
                                    </a>
                                    <p class="date-text"><i class="far fa-calendar-alt me-1"></i>Oct 06, 2022</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 mt-md-0 mt-4">
                    <div class="blog-card-single">
                        <div class="grids5-info">
                            <a href="#blog"><img src="~/assets/images/blog1.jpg" alt="" /></a>
                            <div class="blog-info">
                                <h4><a href="#blog">Very effective and efficient...</a></h4>
                                <p>
                                    Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua, sunt inc
                                    officia deserunt.
                                </p>
                                <div class="d-flex align-items-center justify-content-between mt-4">
                                    <a class="d-flex align-items-center" href="#blog" title="23k followers">
                                        <img class="img-fluid" src="~/assets/images/testi1.jpg" alt="admin"
                                             style="max-width:40px"> <span class="small ms-2">Molive Joe</span>
                                    </a>
                                    <p class="date-text"><i class="far fa-calendar-alt me-1"></i>Oct 10, 2021</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-md-6 mt-lg-0 mt-4">
                    <div class="blog-card-single">
                        <div class="grids5-info">
                            <a href="#blog"><img src="~/assets/images/blog3.jpg" alt="" /></a>
                            <div class="blog-info">
                                <h4><a href="#blog">Articles Programs...</a></h4>
                                <p>
                                    Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua, sunt inc
                                    officia deserunt.
                                </p>
                                <div class="d-flex align-items-center justify-content-between mt-4">
                                    <a class="d-flex align-items-center" href="#blog" title="23k followers">
                                        <img class="img-fluid" src="~/assets/images/testi3.jpg" alt="admin"
                                             style="max-width:40px"> <span class="small ms-2">
                                            Turne Leo
                                        </span>
                                    </a>
                                    <p class="date-text"><i class="far fa-calendar-alt me-1"></i>Oct 12, 2021</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- //blog block -->
    <!-- call block -->
    <section class="w3l-call-to-action-6">
        <div class="container py-md-5 py-sm-4 py-5">
            <div class="d-lg-flex align-items-center justify-content-between">
                <div class="left-content-call">
                    <h3 class="title-big">Customer Services</h3>
                    <p class="text-white mt-1">Need help? Call our CS Now!</p>
                </div>
                <div class="right-content-call mt-lg-0 mt-4">
                    <ul class="buttons">
                        <li class="phone-sec me-lg-4">
                            <i class="fas fa-phone-volume"></i>
                            <a class="call-style-w3" > +(62) 851 xxx xxxx</a>
                        </li>
                        <li>
                            <a href="/Home/Login" class="btn btn-style btn-style-2 mt-lg-0 mt-3">Join for free</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <!-- //call block -->
