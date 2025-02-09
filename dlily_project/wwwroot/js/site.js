document.addEventListener("DOMContentLoaded", function () {
    const profileImg = document.getElementById("profileImg");
    const dropdown = document.getElementById("profileDropdown");

    if (!profileImg || !dropdown) {
        console.error("Profile image or dropdown not found!");
        return;
    }

    profileImg.addEventListener("click", function (event) {
        event.stopPropagation(); // Prevent closing when clicking on the image
        dropdown.classList.toggle("active");
    });

    // Close dropdown when clicking outside
    document.addEventListener("click", function (event) {
        if (!dropdown.contains(event.target) && event.target !== profileImg) {
            dropdown.classList.remove("active");
        }
    });
});


document.addEventListener('DOMContentLoaded', function () {
    const navLinks = document.querySelectorAll('.navbar-nav .nav-link');

    navLinks.forEach(link => {
        link.addEventListener('click', function (e) {
            // Remove active class from all links
            navLinks.forEach(link => link.classList.remove('active'));

            // Add active class to the clicked link
            this.classList.add('active');
        });
    });

    // Set the initial active link based on the current page
    const currentUrl = window.location.href;
    navLinks.forEach(link => {
        if (link.href === currentUrl) {
            link.classList.add('active');
        }
    });
});