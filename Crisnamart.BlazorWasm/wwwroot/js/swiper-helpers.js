(function () {
 // safe no-op if Swiper web components not present yet
 function attachControlsToSwiper(swiperEl) {
 if (!swiperEl) return;
 try {
 const instance = swiperEl.swiper;
 const prevBtn = swiperEl.querySelector('[slot="navigation-prev"]');
 const nextBtn = swiperEl.querySelector('[slot="navigation-next"]');

 if (prevBtn && !prevBtn._attached) {
 prevBtn.addEventListener('click', (ev) => {
 try {
 if (instance && instance.slidePrev) {
 instance.slidePrev();
 if (instance.autoplay && instance.autoplay.running) {
 instance.autoplay.stop();
 }
 }
 } catch (e) {
 console.error('prev click failed', e);
 }
 });
 prevBtn._attached = true;
 console.debug('attached prev to swiper', swiperEl.id || swiperEl);
 }

 if (nextBtn && !nextBtn._attached) {
 nextBtn.addEventListener('click', (ev) => {
 try {
 if (instance && instance.slideNext) {
 instance.slideNext();
 if (instance.autoplay && instance.autoplay.running) {
 instance.autoplay.stop();
 }
 }
 } catch (e) {
 console.error('next click failed', e);
 }
 });
 nextBtn._attached = true;
 console.debug('attached next to swiper', swiperEl.id || swiperEl);
 }

 } catch (err) {
 console.error('attachControlsToSwiper error', err);
 }
 }

 function waitForSwiperInstance(swiperEl, timeoutMs =2000, intervalMs =50) {
 return new Promise((resolve) => {
 if (!swiperEl) return resolve(null);
 let waited =0;
 const check = () => {
 try {
 if (swiperEl.swiper) return resolve(swiperEl.swiper);
 } catch (e) {
 // ignore
 }
 if (waited >= timeoutMs) return resolve(null);
 waited += intervalMs;
 setTimeout(check, intervalMs);
 };
 check();
 });
 }

 async function initializeSwiperElementControlsImpl() {
 const swipers = document.querySelectorAll('swiper-container');
 for (const el of swipers) {
 // wait for element upgrade and instance
 const inst = await waitForSwiperInstance(el,3000,50);
 if (inst) {
 attachControlsToSwiper(el);
 } else {
 // fallback: try attaching anyway after short delay
 setTimeout(() => attachControlsToSwiper(el),100);
 }
 }
 }

 window.initializeSwiperElementControls = function () {
 try {
 initializeSwiperElementControlsImpl().catch((e) => console.error(e));
 } catch (e) {
 console.error('initializeSwiperElementControls error', e);
 }
 };

 window.initializeSwiperElementControlsById = function (id) {
 try {
 const el = document.getElementById(id);
 if (!el) return false;
 waitForSwiperInstance(el,3000,50).then((inst) => {
 if (inst) attachControlsToSwiper(el);
 else setTimeout(() => attachControlsToSwiper(el),100);
 });
 return true;
 } catch (e) {
 console.error('initializeSwiperElementControlsById failed', e);
 return false;
 }
 };

})();