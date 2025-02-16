console.log('hello');

document.addEventListener("DOMContentLoaded", () => {
    // Video Slider Logic
    const videoBtn = document.querySelectorAll('.vid-btn');
    const videoSlider = document.querySelector('#video-slider');

    if (videoBtn.length === 0 || !videoSlider) {
        console.warn("Video buttons or video slider not found.");
        return;
    }

    let videoSources = Array.from(videoBtn).map(btn => btn.getAttribute('data-src')).filter(src => src);
    let currentVideoIndex = 0;

    if (videoSources.length === 0) {
        console.warn("No valid video sources found.");
        return;
    }

    videoBtn.forEach((btn, index) => {
        btn.addEventListener('click', () => {
            currentVideoIndex = index;
            updateVideo();
        });
    });

    function nextVideo() {
        currentVideoIndex = (currentVideoIndex + 1) % videoSources.length;
        updateVideo();
    }

    function prevVideo() {
        currentVideoIndex = (currentVideoIndex - 1 + videoSources.length) % videoSources.length;
        updateVideo();
    }

    function updateVideo() {
        videoSlider.src = videoSources[currentVideoIndex];
        videoSlider.play().catch(err => console.warn("Auto-play blocked:", err));

        document.querySelector('.controls .active')?.classList.remove('active');
        videoBtn[currentVideoIndex].classList.add('active');
    }

    videoSlider.addEventListener('ended', nextVideo);

    document.addEventListener('keydown', (event) => {
        if (event.key === "ArrowRight" || event.key === "d") {
            nextVideo();
        } else if (event.key === "ArrowLeft" || event.key === "a") {
            prevVideo();
        }
    });

    // Initialize the first video
    updateVideo();

    // Cards Rotation Logic
    const cards = document.querySelectorAll('.card');
    const prevBtn = document.getElementById('prev-btn');
    const nextBtn = document.getElementById('next-btn');

    if (cards.length === 0 || !prevBtn || !nextBtn) {
        console.warn("Cards or navigation buttons not found.");
        return;
    }

    let currentIndex = 0;

    function updateCards() {
        cards.forEach((card, index) => {
            card.classList.remove('active', 'prev', 'next');

            if (index === currentIndex) {
                card.classList.add('active');
            } else if (index === (currentIndex + 1) % cards.length) {
                card.classList.add('next');
            } else if (index === (currentIndex - 1 + cards.length) % cards.length) {
                card.classList.add('prev');
            }
        });
    }

    function rotateNext() {
        currentIndex = (currentIndex + 1) % cards.length;
        updateCards();
    }

    function rotatePrev() {
        currentIndex = (currentIndex - 1 + cards.length) % cards.length;
        updateCards();
    }

    prevBtn.addEventListener('click', rotatePrev);
    nextBtn.addEventListener('click', rotateNext);

    // Auto-rotate every 8 seconds
    const interval = setInterval(rotateNext, 8000);

    // Pause auto-rotate on hover
    document.querySelector('.cards-wrapper')?.addEventListener('mouseenter', () => clearInterval(interval));

    // Resume auto-rotate on mouse leave
    document.querySelector('.cards-wrapper')?.addEventListener('mouseleave', () => setInterval(rotateNext, 8000));

    // Handle card clicks
    cards.forEach(card => {
        card.addEventListener('click', () => {
            const clickedIndex = Array.from(cards).indexOf(card);
            if (clickedIndex !== currentIndex) {
                currentIndex = clickedIndex;
                updateCards();
            }
        });
    });

    // Initialize cards
    updateCards();
});
// ddddddddddd
document.addEventListener("DOMContentLoaded", () => {
    const slider = document.querySelector(".slider");
    const slides = document.querySelectorAll(".slide");
    const prevBtn = document.querySelector(".prev-btn");
    const nextBtn = document.querySelector(".next-btn");
    let currentIndex = 0;
    let autoSlideInterval;

    // Function to move to the next slide
    const nextSlide = () => {
        currentIndex = (currentIndex + 1) % slides.length;
        updateSlider();
    };

    // Function to move to the previous slide
    const prevSlide = () => {
        currentIndex = (currentIndex - 1 + slides.length) % slides.length;
        updateSlider();
    };

    // Function to update the slider position
    const updateSlider = () => {
        slider.style.transform = `translateX(-${currentIndex * 100}%)`;
    };

    // Auto-slide functionality
    const startAutoSlide = () => {
        autoSlideInterval = setInterval(nextSlide, 3000); // Change slide every 5 seconds
    };

    const stopAutoSlide = () => {
        clearInterval(autoSlideInterval);
    };

    // Event listeners for buttons
    prevBtn.addEventListener("click", () => {
        stopAutoSlide();
        prevSlide();
        startAutoSlide();
    });

    nextBtn.addEventListener("click", () => {
        stopAutoSlide();
        nextSlide();
        startAutoSlide();
    });

    // Start auto-slide on page load
    startAutoSlide();

    // Pause auto-slide on hover
    slider.addEventListener("mouseenter", stopAutoSlide);
    slider.addEventListener("mouseleave", startAutoSlide);
});



// Modal functionality
// Modal functionality
const modal = document.getElementById('infoModal');
const closeBtn = document.querySelector('.close-btn');

if (closeBtn) {
    closeBtn.addEventListener('click', () => {
        modal.style.display = 'none';
    });
} else {
    console.warn("Close button not found!");
}

const seeMoreBtns = document.querySelectorAll('.see-more');

seeMoreBtns.forEach(btn => {
    btn.addEventListener('click', () => {
        document.getElementById('modalTitle').textContent = btn.dataset.title;
        document.getElementById('modalDesc').textContent = btn.dataset.desc;
        modal.style.display = 'block';
    });
});

closeBtn.addEventListener('click', () => {
    modal.style.display = 'none';
});

window.addEventListener('click', (e) => {
    if (e.target === modal) {
        modal.style.display = 'none';
    }
});

// Initialize slider
showSlide(currentSlide);

// Carousel functionality
document.addEventListener('DOMContentLoaded', () => {
    const track = document.querySelector('.carousel-tracks');
    const cards = document.querySelectorAll('.cards');
    const prevBtn = document.querySelector('.prevs');
    const nextBtn = document.querySelector('.nexts');
    const indicatorsContainer = document.querySelector('.indicatorss');
    let currentIndex = 0;
    let cardWidth = cards[0].offsetWidth + 40;
    let autoSlideInterval;
    let isAnimating = false;

    cards.forEach((_, index) => {
        const indicator = document.createElement('div');
        indicator.classList.add('indicator');
        if (index === 0) indicator.classList.add('active');
        indicator.addEventListener('click', () => goToSlide(index));
        indicatorsContainer.appendChild(indicator);
    });

    function updateCarousel() {
        isAnimating = true;
        track.style.transform = `translateX(-${currentIndex * cardWidth}px)`;

        cards.forEach((card, index) => {
            card.classList.toggle('active', index === currentIndex);
        });

        document.querySelectorAll('.indicator').forEach((indicator, index) => {
            indicator.classList.toggle('active', index === currentIndex);
        });

        setTimeout(() => isAnimating = false, 600);
    }

    function goToSlide(index) {
        if (isAnimating) return;
        currentIndex = (index + cards.length) % cards.length;
        updateCarousel();
        resetAutoSlide();
    }

    function nextSlide() {
        goToSlide(currentIndex + 1);
    }

    function prevSlide() {
        goToSlide(currentIndex - 1);
    }

    function startAutoSlide() {
        autoSlideInterval = setInterval(nextSlide, 6000);
    }

    function resetAutoSlide() {
        clearInterval(autoSlideInterval);
        startAutoSlide();
    }

    // Event listeners
    prevBtn.addEventListener('click', prevSlide);
    nextBtn.addEventListener('click', nextSlide);
    track.addEventListener('mouseenter', () => clearInterval(autoSlideInterval));
    track.addEventListener('mouseleave', startAutoSlide);

    // Touch handling
    let touchStartX = 0;
    let touchEndX = 0;

    track.addEventListener('touchstart', e => {
        touchStartX = e.changedTouches[0].screenX;
    });

    track.addEventListener('touchend', e => {
        touchEndX = e.changedTouches[0].screenX;
        if (Math.abs(touchStartX - touchEndX) > 50) {
            if (touchStartX > touchEndX) nextSlide();
            else prevSlide();
        }
    });

    // Initialize
    updateCarousel();
    startAutoSlide();

    window.addEventListener('resize', () => {
        cardWidth = cards[0].offsetWidth + 40;
        updateCarousel();
    });

    document.addEventListener('keydown', (e) => {
        if (e.key === 'ArrowLeft') prevSlide();
        if (e.key === 'ArrowRight') nextSlide();
    });
});

// Additional Slider Functionality
const trackL = document.querySelector('.slider-trackl');
const cardsL = document.querySelectorAll('.cardl');
const prevBtnL = document.querySelector('.prev-btnl');
const nextBtnL = document.querySelector('.next-btnl');

if (!prevBtnL || !nextBtnL) {
    console.warn("Previous or Next buttons not found!");
} else {
    let currentIndexL = 0;
    let cardWidthL = cardsL[0].offsetWidth + 30; // Include margin

    function updateSlider() {
        trackL.style.transform = `translateX(-${currentIndexL * cardWidthL}px)`;
    }

    nextBtnL.addEventListener('click', () => {
        currentIndexL = Math.min(currentIndexL + 1, cardsL.length - 1);
        updateSlider();
    });

    prevBtnL.addEventListener('click', () => {
        currentIndexL = Math.max(currentIndexL - 1, 0);
        updateSlider();
    });

    // Handle window resize
    window.addEventListener('resize', () => {
        cardWidthL = cardsL[0].offsetWidth + 30;
        updateSlider();
    });
}
