var navigation = document.querySelector('.category');
var navigations = document.querySelectorAll('.navigation');
firsMenu(navigations);

function createBTN(text, id) {
	var newBtn = document.createElement('li');
	var link = document.createElement('a');
	link.classList.add('navigation');
	link.setAttribute('href', '#');
	link.setAttribute('id', id);
	link.textContent = text;
	newBtn.append(link);
	return newBtn;
}

function ComeBackBaseComplect() {
	var oldUlcontanier = document.querySelector('#category');
	var oldUl = document.querySelector('.category');
	oldUl.remove();
	var newUl = document.createElement('ul');
	newUl.classList.add('category');
	newUl.appendChild(createBTN('Спорт', 'sport'));
	newUl.appendChild(createBTN('Кинотеатры', 'cinema'));
	newUl.appendChild(createBTN('Парки', 'parks'));
	oldUlcontanier.appendChild(newUl);
}

function DeleteNavigations() {
	let navigations = document.querySelectorAll('.navigation');
	for (var i = 0; i < navigations.length; i++) {
		navigations[i].remove();
	}
}

function AddDescription(name, text) {
	var par = document.querySelector('#descriptionName');
	par.textContent = name;
	var content = document.querySelector('#descriptionText');
	content.textContent = text;
}

function firsMenu(navigations) {
	for (var i = 0; i < navigations.length; i++) {
		navigations[i].addEventListener('click', function (evt) {

			switch (this.id) {
				case 'sport':
					DeleteNavigations();
					navigation.appendChild(createBTN('Качалочка', 'sport1'));
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'cinema':
					DeleteNavigations();
					navigation.appendChild(createBTN('Кинотеатр Маяковский', 'cinema1'));
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'parks':
					DeleteNavigations();
					navigation.appendChild(createBTN('Зеленый остров', 'park1'));
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'sport1':
					AddDescription('Фитнес Клуб Alex Fitness', 'Время работы: ежедневно 07:00-22:00<br>Адрес: ул.Дианова, 7 / 1, Омск, Омская обл., 644106<br>Средняя цена: 37 руб в день')
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'back':
					ComeBackBaseComplect();
					break;
			}
			var newNaw = document.querySelectorAll('.navigation');
			firsMenu(newNaw);
		});
	}
}