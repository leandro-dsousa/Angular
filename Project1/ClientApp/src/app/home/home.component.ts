import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  
  selected_post: Post = {
    id: '',
    description: { _description: '' },
    title: { _title: '' },
    author: { _author: '' },
    url: { _url: '' },
  };

  posts: Post[] = [];

  setSelectedPost(post: Post) {
    this.selected_post = post;
  }

  async ngOnInit() {
    const response = fetch('https://localhost:44492/home', { method: 'GET' });

    if (!(await response).ok) {
      throw new Error(`Error! status: ${(await response).status}`);
    }

    const result = (await response).json();

    await result.then((result) => {
      this.posts = result;
    });
  }
}

interface Post {
  id: string;
  description: Description;
  author: Author;
  title: Title;
  url: Url;
}

interface Description {
  _description: string;
}

interface Author {
  _author: string;
}

interface Title {
  _title: string;
}

interface Url {
  _url: string;
}
