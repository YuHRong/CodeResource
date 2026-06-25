const recipeForm = document.getElementById('recipe-form');
const recipeList = document.getElementById('recipe-list');
const recipeCount = document.getElementById('recipe-count');
const recipeNameInput = document.getElementById('recipe-name');
const recipeDescriptionInput = document.getElementById('recipe-description');

const recipes = [
  {
    name: 'Lemon Garlic Pasta',
    description: 'Tossed with olive oil, fresh lemon, garlic, and parsley for a bright dinner.',
    favorite: true
  },
  {
    name: 'Roasted Veggie Bowl',
    description: 'Colorful seasonal vegetables with quinoa, tahini sauce, and toasted seeds.',
    favorite: false
  },
  {
    name: 'Berry Yogurt Parfait',
    description: 'Layers of creamy yogurt, honey, granola, and fresh berries for breakfast.',
    favorite: false
  }
];

function renderRecipes() {
  recipeList.innerHTML = '';
  recipeCount.textContent = recipes.length;

  const sortedRecipes = [...recipes].sort((a, b) => Number(b.favorite) - Number(a.favorite));

  sortedRecipes.forEach((recipe, index) => {
    const item = document.createElement('li');
    item.className = 'recipe-item';

    const title = document.createElement('h3');
    title.textContent = recipe.name;

    const description = document.createElement('p');
    description.textContent = recipe.description;

    const actions = document.createElement('div');
    actions.className = 'recipe-actions';

    const favoriteButton = document.createElement('button');
    favoriteButton.type = 'button';
    favoriteButton.className = 'btn-favorite';
    favoriteButton.innerHTML = recipe.favorite ? '★ Favorite' : '☆ Favorite';
    favoriteButton.setAttribute('aria-pressed', recipe.favorite);
    favoriteButton.addEventListener('click', () => {
      recipe.favorite = !recipe.favorite;
      renderRecipes();
    });

    const deleteButton = document.createElement('button');
    deleteButton.type = 'button';
    deleteButton.className = 'btn-delete';
    deleteButton.textContent = 'Delete';
    deleteButton.addEventListener('click', () => {
      const recipeIndex = recipes.findIndex((itemRecipe) => itemRecipe === recipe);
      recipes.splice(recipeIndex, 1);
      renderRecipes();
    });

    actions.appendChild(favoriteButton);
    actions.appendChild(deleteButton);
    item.appendChild(title);
    item.appendChild(description);
    item.appendChild(actions);
    recipeList.appendChild(item);
  });
}

recipeForm.addEventListener('submit', (event) => {
  event.preventDefault();

  const name = recipeNameInput.value.trim();
  const description = recipeDescriptionInput.value.trim();

  if (!name || !description) {
    return;
  }

  recipes.push({ name, description });
  recipeNameInput.value = '';
  recipeDescriptionInput.value = '';
  recipeNameInput.focus();
  renderRecipes();
});

renderRecipes();
