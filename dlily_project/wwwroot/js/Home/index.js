console.log('hello');

document.addEventListener("DOMContentLoaded", () => {
    // Video Slider Logic
    const videoBtn = document.querySelectorAll('.vid-btn');
    const videoSlider = document.querySelector('#video-slider');

    if (videoBtn.length > 0 && videoSlider) {
        let videoSources = Array.from(videoBtn).map(btn => btn.getAttribute('data-src')).filter(src => src);
        let currentVideoIndex = 0;

        if (videoSources.length > 0) {
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
        }
    }

    // Cards Rotation Logic (for other cards, not tourguides)
    const cards = document.querySelectorAll('.card');
    const prevBtn = document.getElementById('prev-btn');
    const nextBtn = document.getElementById('next-btn');

    if (cards.length > 0 && prevBtn && nextBtn) {
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
        let interval = setInterval(rotateNext, 8000);

        // Pause auto-rotate on hover
        const cardsWrapper = document.querySelector('.cards-wrapper');
        if (cardsWrapper) {
            cardsWrapper.addEventListener('mouseenter', () => clearInterval(interval));
            cardsWrapper.addEventListener('mouseleave', () => {
                interval = setInterval(rotateNext, 8000);
            });
        }

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
    }

    // Basic Slider Logic (for .slider elements)
    const slider = document.querySelector(".slider");
    const slides = document.querySelectorAll(".slide");
    const sliderPrevBtn = document.querySelector(".prev-btn");
    const sliderNextBtn = document.querySelector(".next-btn");

    if (slider && slides.length > 0 && sliderPrevBtn && sliderNextBtn) {
        let currentIndex = 0;
        let autoSlideInterval;

        const nextSlide = () => {
            currentIndex = (currentIndex + 1) % slides.length;
            updateSlider();
        };

        const prevSlide = () => {
            currentIndex = (currentIndex - 1 + slides.length) % slides.length;
            updateSlider();
        };

        const updateSlider = () => {
            slider.style.transform = `translateX(-${currentIndex * 100}%)`;
        };

        const startAutoSlide = () => {
            autoSlideInterval = setInterval(nextSlide, 3000);
        };

        const stopAutoSlide = () => {
            clearInterval(autoSlideInterval);
        };

        sliderPrevBtn.addEventListener("click", () => {
            stopAutoSlide();
            prevSlide();
            startAutoSlide();
        });

        sliderNextBtn.addEventListener("click", () => {
            stopAutoSlide();
            nextSlide();
            startAutoSlide();
        });

        startAutoSlide();

        slider.addEventListener("mouseenter", stopAutoSlide);
        slider.addEventListener("mouseleave", startAutoSlide);
    }

    // TOURGUIDES CAROUSEL - Fixed Implementation
    const tourguidesTrack = document.querySelector('.carousel-tracks');
    const tourguidesCards = document.querySelectorAll('.carousel-tracks .cards');
    const tourguidesPrevBtn = document.querySelector('.prevs');
    const tourguidesNextBtn = document.querySelector('.nexts');
    const tourguidesIndicatorsContainer = document.querySelector('.indicatorss');

    if (tourguidesTrack && tourguidesCards.length > 0 && tourguidesPrevBtn && tourguidesNextBtn && tourguidesIndicatorsContainer) {
        let tourguidesCurrentIndex = 0;
        let tourguidesAutoSlideInterval;
        let tourguidesIsAnimating = false;

        // Calculate card width dynamically
        function getCardWidth() {
            const cardStyle = window.getComputedStyle(tourguidesCards[0]);
            const cardWidth = tourguidesCards[0].offsetWidth;
            const marginLeft = parseFloat(cardStyle.marginLeft) || 0;
            const marginRight = parseFloat(cardStyle.marginRight) || 0;
            return cardWidth + marginLeft + marginRight;
        }

        let tourguidesCardWidth = getCardWidth();

        // Create indicators
        tourguidesIndicatorsContainer.innerHTML = '';
        tourguidesCards.forEach((_, index) => {
            const indicator = document.createElement('div');
            indicator.classList.add('indicator');
            if (index === 0) indicator.classList.add('active');
            indicator.addEventListener('click', () => tourguidesGoToSlide(index));
            tourguidesIndicatorsContainer.appendChild(indicator);
        });

        function tourguidesUpdateCarousel() {
            tourguidesIsAnimating = true;
            tourguidesTrack.style.transform = `translateX(-${tourguidesCurrentIndex * tourguidesCardWidth}px)`;

            // Update active states
            tourguidesCards.forEach((card, index) => {
                card.classList.toggle('active', index === tourguidesCurrentIndex);
            });

            // Update indicators
            document.querySelectorAll('.indicatorss .indicator').forEach((indicator, index) => {
                indicator.classList.toggle('active', index === tourguidesCurrentIndex);
            });

            setTimeout(() => tourguidesIsAnimating = false, 600);
        }

        function tourguidesGoToSlide(index) {
            if (tourguidesIsAnimating) return;
            tourguidesCurrentIndex = (index + tourguidesCards.length) % tourguidesCards.length;
            tourguidesUpdateCarousel();
            tourguidesResetAutoSlide();
        }

        function tourguidesNextSlide() {
            tourguidesGoToSlide(tourguidesCurrentIndex + 1);
        }

        function tourguidesPrevSlide() {
            tourguidesGoToSlide(tourguidesCurrentIndex - 1);
        }

        function tourguidesStartAutoSlide() {
            tourguidesAutoSlideInterval = setInterval(tourguidesNextSlide, 6000);
        }

        function tourguidesResetAutoSlide() {
            clearInterval(tourguidesAutoSlideInterval);
            tourguidesStartAutoSlide();
        }

        // Event listeners
        tourguidesPrevBtn.addEventListener('click', tourguidesPrevSlide);
        tourguidesNextBtn.addEventListener('click', tourguidesNextSlide);

        tourguidesTrack.addEventListener('mouseenter', () => clearInterval(tourguidesAutoSlideInterval));
        tourguidesTrack.addEventListener('mouseleave', tourguidesStartAutoSlide);

        // Touch handling for mobile
        let touchStartX = 0;
        let touchEndX = 0;

        tourguidesTrack.addEventListener('touchstart', e => {
            touchStartX = e.changedTouches[0].screenX;
        });

        tourguidesTrack.addEventListener('touchend', e => {
            touchEndX = e.changedTouches[0].screenX;
            if (Math.abs(touchStartX - touchEndX) > 50) {
                if (touchStartX > touchEndX) tourguidesNextSlide();
                else tourguidesPrevSlide();
            }
        });

        // Handle window resize
        window.addEventListener('resize', () => {
            tourguidesCardWidth = getCardWidth();
            tourguidesUpdateCarousel();
        });

        // Initialize tourguides carousel
        tourguidesUpdateCarousel();
        tourguidesStartAutoSlide();
    }

    // Additional Slider Functionality (for .slider-trackl)
    const trackL = document.querySelector('.slider-trackl');
    const cardsL = document.querySelectorAll('.cardl');
    const prevBtnL = document.querySelector('.prev-btnl');
    const nextBtnL = document.querySelector('.next-btnl');

    if (trackL && cardsL.length > 0 && prevBtnL && nextBtnL) {
        let currentIndexL = 0;
        let cardWidthL = cardsL[0].offsetWidth + 30;

        function updateSliderL() {
            trackL.style.transform = `translateX(-${currentIndexL * cardWidthL}px)`;
        }

        nextBtnL.addEventListener('click', () => {
            currentIndexL = Math.min(currentIndexL + 1, cardsL.length - 1);
            updateSliderL();
        });

        prevBtnL.addEventListener('click', () => {
            currentIndexL = Math.max(currentIndexL - 1, 0);
            updateSliderL();
        });

        window.addEventListener('resize', () => {
            cardWidthL = cardsL[0].offsetWidth + 30;
            updateSliderL();
        });
    }
});

// Modal functionality
document.addEventListener("DOMContentLoaded", () => {
    const modal = document.getElementById('infoModal');
    const closeBtn = document.querySelector('.close-btn');
    const seeMoreBtns = document.querySelectorAll('.see-more');

    if (modal && closeBtn) {
        closeBtn.addEventListener('click', () => {
            modal.style.display = 'none';
        });

        window.addEventListener('click', (e) => {
            if (e.target === modal) {
                modal.style.display = 'none';
            }
        });
    }

    if (seeMoreBtns.length > 0 && modal) {
        seeMoreBtns.forEach(btn => {
            btn.addEventListener('click', () => {
                const modalTitle = document.getElementById('modalTitle');
                const modalDesc = document.getElementById('modalDesc');

                if (modalTitle && modalDesc) {
                    modalTitle.textContent = btn.dataset.title;
                    modalDesc.textContent = btn.dataset.desc;
                    modal.style.display = 'block';
                }
            });
        });
    }
});