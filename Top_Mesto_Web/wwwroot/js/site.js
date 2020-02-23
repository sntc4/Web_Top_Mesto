var navigation = document.querySelector('.category');
//var navigations = document.querySelectorAll('.navigation');

firsMenu();

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
	DeleteNavigations();
	var newUl = document.querySelector('.category');
	newUl.appendChild(createBTN('Спорт', 'sport'));
	newUl.appendChild(createBTN('Кинотеатры', 'cinema'));
	newUl.appendChild(createBTN('Парки', 'parks'));
}

function DeleteNavigations() {
	let navigations = document.querySelector('.category').querySelectorAll('li');
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

function ClearDescription() {
	AddDescription('Описание', '')
}

function firsMenu() {
	var navigations = document.querySelectorAll('.navigation');
	for (var i = 0; i < navigations.length; i++) {
		navigations[i].addEventListener('click', function (evt) {

			switch (this.id) {
				case 'sport':
					console.log(this.id);
					DeleteNavigations();
					navigation.appendChild(createBTN('Качалочка', 'sport1'));
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'cinema':
					DeleteNavigations();
					navigation.appendChild(createBTN('Маяковский', 'cinema1'));
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'parks':
					DeleteNavigations();
					navigation.appendChild(createBTN('Зеленый остров', 'park1'));
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'sport1':
					DeleteNavigations();
					AddDescription('Фитнес Клуб Alex Fitness', "Время работы: ежедневно 07:00-22:00 Адрес: ул.Дианова, 7 / 1, Омск, Омская обл., 644106 Средняя цена: 37 руб в день");
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'back':
					ComeBackBaseComplect();
					ClearDescription();
					break;
				case 'cinema1':
					DeleteNavigations();
					AddDescription('Кинотеатр Маяковский', "Время работы: ежедневно 09:00–00:00 Адрес: ул.Красный Путь, 4, Омск, Омская обл., 644043 Средняя цена фильмов: 175");
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
				case 'park1':
					DeleteNavigations();
					AddDescription('Парк "Зелёный Остров"', "Адрес: ул. Старозагородная Роща, 10/1 Площадь: 70 га");
					navigation.appendChild(createBTN('<< Назад', 'back'));
					break;
			}
			//var newNaw = document.querySelectorAll('.navigation');
			firsMenu();
		});
	}
}