* {
  padding: 0;
  margin: 0;
  border: 0; }

*,
*:before,
*:after {
  -moz-box-sizing: border-box;
  -webkit-box-sizing: border-box;
  box-sizing: border-box; }

:focus,
:active {
  outline: none; }

a:focus,
a:active {
  outline: none; }

nav,
footer,
header,
aside {
  display: block; }

html,
body {
  height: 100%;
  width: 100%;
  font-size: 100%;
  line-height: 1;
  font-size: 16px;
  -ms-text-size-adjust: 100%;
  -moz-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%; }

input,
button,
textarea {
  font-family: inherit; }

button {
  background: none;
  border: none;
  color: none; }

input::-ms-clear {
  display: none; }

button {
  cursor: pointer; }

button::-moz-focus-inner {
  padding: 0;
  border: 0; }

a,
a:visited {
  text-decoration: none; }

a:hover {
  text-decoration: none; }

ul li {
  list-style: none; }

img {
  vertical-align: top; }

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit; }

a {
  color: inherit; }

body {
  font-family: 'Lato', sans-serif; }

.wraper {
  min-height: 100%;
  width: 100%;
  overflow: hidden; }

.burger {
  display: none; }

.container {
  max-width: 1260px;
  padding: 0 15px;
  margin: 0 auto;
  height: 100%; }

.overlay {
  position: fixed;
  inset: 0;
  z-index: 50;
  background: rgba(0, 0, 0, 0.349);
  visibility: hidden;
  opacity: 0;
  transition: all 0.8s; }

.overlay--active {
  visibility: visible;
  opacity: 1; }

.heading__title {
  font-family: 'Cinzel', serif;
  font-weight: 700;
  font-size: 44px;
  line-height: 150%;
  color: #ffffff;
  mix-blend-mode: luminosity; }
  .heading__title--big {
    font-size: 52px;
    line-height: 62px; }
  .heading__title--black {
    font-size: 40px;
    line-height: 120%;
    color: #000000; }

.heading__subtitle {
  font-weight: 500;
  font-size: 20px;
  line-height: 160%;
  color: rgba(255, 255, 255, 0.7);
  mix-blend-mode: luminosity; }
  .heading__subtitle--black {
    font-weight: 400;
    font-size: 20px;
    line-height: 130%;
    color: rgba(0, 0, 0, 0.8); }
  .heading__subtitle--end {
    align-self: flex-end; }

.button {
  background: linear-gradient(180deg, #833ef1 0%, #491cb5 100%);
  border-radius: 8px;
  font-weight: 700;
  font-size: 16px;
  line-height: 19px;
  color: #ffffff; }
  .button--empty {
    border: 1px solid #833ef1;
    background: none;
    color: #833ef1; }

.button:hover {
  transform: scale(1.1);
  transition: all 0.3s; }

.creators {
  background: #030303 url(../../assets/png/background/creators.png) 50% 50%/cover no-repeat; }

.creators .container {
  max-width: 100%; }

.creators__inner {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 55px; }

.creators__heading {
  text-align: center; }

.creators__heading .heading__subtitle {
  width: 458px; }

.creators__runingline-window {
  width: 100%; }

.creators__runingline {
  display: flex;
  gap: 25px; }

.creators__runingline {
  position: absolute; }

.creators__runingline-col {
  display: flex;
  flex-direction: column;
  gap: 21px;
  justify-content: center; }

.creators__runingline-item {
  border-radius: 14px; }

.creators__button {
  padding: 14px 22px; }

@keyframes marquee {
  to {
    transform: translate(var(--marquee-x, -100%), var(--marquee-y, 0)); } }

.animate {
  overflow: hidden; }
  .animate .creators__runingline {
    animation: marquee var(--marquee-duration, 20s) infinite linear;
    position: relative;
    padding-left: 100%;
    width: max-content; }

.digital {
  background: #ebebeb;
  margin-top: -45px; }
  .digital__inner {
    padding: 90px 0 95px;
    display: flex;
    flex-direction: column;
    align-items: center;
    position: relative; }
  .digital__heading {
    max-width: 549px;
    display: flex;
    flex-direction: column;
    align-items: center;
    text-align: center; }
  .digital__heading .heading__subtitle {
    max-width: 390px; }
  .digital__slider {
    margin-top: 52px;
    display: flex;
    position: relative;
    flex-direction: column;
    align-items: center;
    justify-content: space-between;
    perspective: 50rem; }
  .digital__arrows {
    position: absolute;
    top: 55%;
    left: 100px;
    right: 100px;
    transform: translateY(-50%);
    display: flex;
    justify-content: space-between; }
  .digital__arrow {
    width: 56px;
    height: 56px;
    background: #fff;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 50%;
    font-weight: 900;
    font-size: 28px; }
  .digital__arrow:hover {
    box-shadow: 3px 2px 15px #bdb5b5; }
  .digital__slider-items {
    display: flex;
    gap: 25px;
    position: relative;
    width: 17rem;
    height: 25rem;
    transform-style: preserve-3d;
    transform: translateZ(-25rem);
    transition: all 0.5s; }
  .digital__slider-item {
    width: 100%;
    height: 100%;
    position: absolute; }
  .digital__slider-item:nth-child(1) {
    transform: rotateY(0deg) translateZ(25rem); }
  .digital__slider-item:nth-child(2) {
    transform: rotateY(120deg) translateZ(25rem); }
  .digital__slider-item:nth-child(3) {
    transform: rotateY(240deg) translateZ(25rem); }
  .digital__item-img {
    border-radius: 16px 16px 0 0px;
    width: 100%; }
  .digital__item-text {
    padding: 12px 16px;
    background: #fff;
    border-radius: 0 0 16px 16px; }
  .digital__item-heading {
    font-family: 'Cinzel', serif;
    font-weight: 700;
    font-size: 17.473px;
    line-height: 24px; }
  .digital__item-description {
    font-weight: 600;
    font-size: 11.2327px;
    line-height: 13px;
    color: rgba(0, 0, 0, 0.54); }
  .digital__button {
    margin-top: 40px;
    padding: 14px 22px; }

.header {
  background: #000 url(../../assets/png/background/header.png) 100% 100%/cover no-repeat;
  border-radius: 0px 0px 95% 95% / 0px 0px 11% 11%;
  z-index: 1;
  position: relative; }
  .header__inner {
    background: linear-gradient(90.18deg, rgba(61, 61, 61, 0.2052) 0%, rgba(29, 29, 29, 0.285) 100%);
    backdrop-filter: blur(10px);
    border-radius: 0px 0px 15px 15px;
    height: 80px;
    min-width: 1296px; }
  .header__top {
    display: flex;
    align-items: center;
    padding: 15px 25px; }
  .header__logo {
    margin-right: 37px; }
  .header__search {
    width: 516px;
    height: 48px;
    background: rgba(79, 79, 79, 0.4);
    border: 1px solid #3b3b3b;
    border-radius: 8px;
    margin-right: 93px;
    padding-left: 59px;
    font-size: 16px; }
  .header__search-wrap {
    position: relative; }
  .header__search-wrap::before {
    content: '';
    position: absolute;
    top: 25%;
    left: 23px;
    pointer-events: none;
    width: 24px;
    height: 24px;
    background: url("../../assets/png/logos/Search.svg"); }
  .header__search::placeholder {
    font-weight: 500;
    font-size: 16px;
    line-height: 21px;
    color: #8a8a8a; }
  .header__navigation-list {
    display: flex;
    gap: 37px;
    margin-right: 92px; }
  .header__navigation-item {
    color: rgba(255, 255, 255, 0.7); }
  .header .header__top-button {
    padding: 14px 22px; }
  .header__body {
    padding: 170px 0 272px; }
  .header__body-inner {
    display: flex;
    align-items: center;
    flex-direction: column; }
  .header__heading {
    max-width: 723px;
    gap: 13px;
    display: flex;
    flex-direction: column;
    align-items: center;
    text-align: center; }
  .header__heading .heading__subtitle {
    max-width: 505px; }
  .header__body-button {
    margin-top: 52px;
    padding: 14px 22px; }

.about {
  background: #030303 url(../../assets/png/background/whoare.png) 40% 40%/cover no-repeat;
  border-radius: 95% 95% 0px 0px / 11% 11% 0px 0px;
  margin-top: -40px;
  z-index: 1;
  position: relative; }

.about__inner {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 46px 0 226px; }

.about__heading {
  display: flex;
  flex-direction: column;
  text-align: center;
  align-items: flex-start;
  width: 552px;
  gap: 14px; }

.about__heading .heading__subtitle {
  max-width: 417px; }

.about__button {
  margin-top: 56px;
  position: relative;
  padding: 14px 22px;
  padding-right: 49px; }

.about__button::after {
  content: '';
  position: absolute;
  width: 27px;
  height: 20px;
  background: url(../../assets/png/logos/Vector.svg);
  top: 50%;
  transform: translateY(-50%);
  right: 7%; }

.footer {
  background: #030303 url(../../assets/png/background/footer.svg); }

.footer__inner {
  display: flex;
  flex-direction: column;
  padding: 104px 0 54px; }

.footer__top-inner {
  font-family: 'Poppins', sans-serif;
  display: flex;
  justify-content: space-between;
  gap: 152px;
  font-weight: 400;
  font-size: 14px;
  line-height: 22px;
  color: #ffffff; }

.footer__label {
  font-family: 'Cinzel', serif;
  margin-bottom: 20px;
  font-weight: 400;
  font-size: 16px;
  line-height: 28px;
  color: #ffffff;
  opacity: 1; }

.footer__nav-list,
.footer__social-list {
  display: flex;
  align-items: center;
  flex-direction: column;
  gap: 15px; }

.footer__nav-item,
.footer__social-item {
  opacity: 0.75; }

.footer__nav-item:hover,
.footer__social-item:hover {
  opacity: 1;
  transition: all 0.3s; }

.footer__adres {
  max-width: 302px;
  opacity: 0.75; }

.footer__form {
  margin-top: 48px;
  display: flex;
  flex-direction: column; }

.footer__form-items {
  display: flex; }

.footer__form-input {
  background: none;
  width: 100%;
  color: #fff; }

.footer__form hr {
  height: 1px;
  margin-top: 10px;
  background: #fff;
  opacity: 0.25; }

.footer__form-input::placeholder {
  color: #ffffff;
  font-weight: 400;
  font-size: 14px;
  line-height: 22px;
  opacity: 0.7; }

.footer__form-btn {
  width: 26px;
  height: 18px;
  background: url(../../assets/png/logos/Mail.svg); }

.footer__bottom {
  margin-top: 110px;
  font-weight: 300;
  font-size: 18px;
  line-height: 24px;
  text-align: justify;
  color: #ffffff; }

.footer__bottom-inner {
  display: flex;
  justify-content: space-between; }

.footer__phone::after,
.footer__mail::after {
  content: '';
  background: #fff;
  height: 2px;
  display: block;
  width: 100%;
  margin-top: 10px; }

.footer__copy {
  font-family: 'Poppins', sans-serif;
  font-weight: 400;
  font-size: 12px;
  line-height: 20px;
  opacity: 0.6; }

@media (max-width: 1300px) {
  .header__search-wrap {
    max-width: 530px; }
  .header__navigation-list {
    margin-right: 49px; } }

@media (max-width: 1200px) {
  .header__inner {
    min-width: 320px;
    position: fixed;
    top: 0;
    left: 0;
    bottom: 0;
    background: #313131;
    z-index: 100;
    height: 100%;
    border-radius: 0;
    transform: translateX(-100%);
    transition: all 0.4s; }
  .header__inner--active {
    transform: translateX(0); }
  .header__top {
    justify-content: space-between;
    padding: 50px 15px;
    align-items: center;
    flex-direction: column;
    height: 100%; }
  .header__navigation-list {
    text-align: center; }
  .header__logo {
    margin-right: 0; }
  .header__navigation-list {
    margin-right: 0;
    flex-direction: column;
    gap: 80px; }
  .burger {
    position: fixed;
    background-color: #fff;
    box-shadow: 0 1px 8px 0 #a1a1a1;
    top: 15px;
    left: 15px;
    z-index: 150;
    width: 60px;
    height: 60px;
    border-radius: 50%;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    transition: all 0.4s; }
  .burger span {
    background-color: #424551;
    display: block;
    width: 40px;
    height: 3px;
    border-radius: 4px;
    background-color: #424551;
    margin: 4px 0; }
  .burger::before,
  .burger::after {
    content: '';
    display: block;
    width: 40px;
    height: 3px;
    background-color: #424551;
    border-radius: 4px;
    transition: all 0.2s; }
  .burger--active span {
    display: none; }
  .burger--active::before {
    transform: rotate(45deg) translateY(50%); }
  .burger--active::after {
    transform: rotate(-45deg); } }

@media (max-width: 920px) {
  .footer__adres {
    max-width: 175px; }
  .footer__top-inner {
    gap: 75px; }
  .footer__form-btn {
    width: 28px; }
  .footer__form-input {
    margin-right: 3px; }
  .footer__logo {
    display: none; }
  .digital__slider-items {
    width: 14rem;
    height: 20rem; }
  .digital__slider {
    perspective: 30rem; } }

@media (max-width: 750px) {
  .digital__slider-items {
    width: 11rem; }
  .digital__slider {
    perspective: 18rem; }
  .digital__arrows {
    left: 30px;
    right: 30px; } }

@media (max-width: 550px) {
  .header__inner {
    right: 0; }
  .footer__top-inner {
    gap: 30px; }
  .footer__adres {
    max-width: 154px; }
  .about__heading {
    width: 483px; }
  .footer__form-input {
    margin-right: 3px; }
  .heading__subtitle {
    font-size: 14px; }
  .heading__title {
    font-size: 30px; }
  .heading__title--black {
    font-size: 28px; }
  .heading__subtitle--black {
    font-size: 14px; }
  .heading__title--big {
    font-size: 36px; }
  .footer__bottom-inner {
    justify-content: center;
    flex-wrap: wrap;
    gap: 30px;
    align-items: center; }
  .header__search {
    margin-right: 0;
    width: 289px; }
  .creators__runingline-item {
    width: 140px; }
  .about__heading .heading__subtitle {
    max-width: 380px; }
  .about__heading {
    width: 415px; }
  .creators__heading .heading__subtitle {
    width: 270px; }
  .digital__arrows {
    left: 0;
    right: 0; }
  .digital__slider {
    perspective: 14rem; }
  .digital__slider-items {
    width: 10rem; }
  .digital__arrow {
    width: 41px;
    height: 41px;
    font-size: 20px; }
  .digital__arrows {
    position: relative;
    margin-top: 35px; }
  .digital__slider-items {
    height: 15rem; }
  .digital__slider {
    margin-top: -1px; } }

@media (max-width: 330px) {
  .footer__top-inner {
    flex-wrap: wrap;
    justify-content: space-around; }
  .footer__top-inner {
    flex-wrap: wrap; }
  .footer__top-inner {
    justify-content: space-around; }
  .about__heading .heading__subtitle {
    max-width: 220px; }
  .about__heading {
    width: auto; }
  .header__search {
    width: 224px; }
  .creators__heading .heading__subtitle {
    width: auto; }
  .about__inner {
    align-items: center; }
  .button {
    font-size: 13px; }
  .header__inner {
    min-width: 151px; }
  .digital__slider {
    perspective: 8rem; }
  .digital__slider-items {
    width: 8rem;
    height: 13rem; }
  .digital__item-heading {
    font-size: 14px; }
  .digital__item-description {
    font-size: 9.2px; } }
