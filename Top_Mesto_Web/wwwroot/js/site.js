// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
var btnSport = document.querySelector('#sport');
var navigation = document.querySelector('#category');
//btn.classList.add('redBack');
btnSport.addEventListener('click', function (evt) {
	evt.preventDefault();
	//this.classList.add('redBack');
	var navigations = document.querySelectorAll('li');
	for (var i = 0; i < navigations.length; i++) {
		navigations[i].remove();
	}
	var year30VLKSM = document.createElement('a');
	year30VLKSM.classList.add('navigation');
	year30VLKSM.setAttribute('href', '#');
	year30VLKSM.textContent = 'Зеленый остров';
	var newLi = document.createElement('li');
	newLi.append(year30VLKSM);
	navigation.append(newLi);
	year30VLKSM.addEventListener('click', function (evt) {
		evt.preventDefault();
		var description = document.querySelector('#description');
		var textDescription = 'Зеленый остров это классный парк, где можно искупиться в проруби';
		description.textContent = textDescription;
	});
});