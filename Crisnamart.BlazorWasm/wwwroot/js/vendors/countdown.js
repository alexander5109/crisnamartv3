// Timer Countdown

(function () {
	// no-op fallback
	if (typeof window.initializeCountdowns !== 'function') {
		window.initializeCountdowns = function () {
			console.warn('initializeCountdowns called before countdown script loaded');
		};
	}

	function initCountdownsImpl() {
		document.querySelectorAll('[data-countdown]').forEach(function (element) {
			var finalDate = element.getAttribute('data-countdown');

			function updateCountdown() {
				var now = new Date().getTime();
				var distance = new Date(finalDate) - now;

				if (distance <= 0) {
					clearInterval(interval);
					element.innerHTML = 'Countdown expired';
					return;
				}

				var days = Math.floor(distance / (1000 * 60 * 60 * 24));
				var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
				var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
				var seconds = Math.floor((distance % (1000 * 60)) / 1000);

				element.innerHTML =
					'<span class="countdown-section"><span class="countdown-amount hover-up">' +
					days +
					'</span><span class="countdown-period"> days </span></span>' +
					'<span class="countdown-section"><span class="countdown-amount hover-up">' +
					hours +
					'</span><span class="countdown-period"> hours </span></span>' +
					'<span class="countdown-section"><span class="countdown-amount hover-up">' +
					minutes +
					'</span><span class="countdown-period"> mins </span></span>' +
					'<span class="countdown-section"><span class="countdown-amount hover-up">' +
					seconds +
					'</span><span class="countdown-period"> sec </span></span>';
			}

			updateCountdown(); // Call it immediately to set the initial value
			var interval = setInterval(updateCountdown, 1000); // Update the countdown every second
		});
	}

	// run on load as fallback
	if (document.readyState === 'complete' || document.readyState === 'interactive') {
		setTimeout(initCountdownsImpl, 50);
	} else {
		window.addEventListener('DOMContentLoaded', function () {
			setTimeout(initCountdownsImpl, 50);
		});
	}

	window.initializeCountdowns = function () {
		try {
			initCountdownsImpl();
		} catch (e) {
			console.error('initializeCountdowns failed', e);
		}
	};
})();
