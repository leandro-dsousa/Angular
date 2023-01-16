import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-basic-modal',
  templateUrl: './basic-modal.component.html',
  styleUrls: ['./basic-modal.component.css'],
})
export class BasicModalComponent {
  @Input() Image = '';
  @Input() Title = '';
  @Input() Author = '';
  @Input() Description = '';

  ngOnInit() {
    var modal = document.getElementById('modal') as HTMLDialogElement;
    modal.querySelector('.btn-close')?.addEventListener('click', () => {
      modal.close();
    });
    modal.addEventListener('click', function (event) {
      var rect = modal.getBoundingClientRect();
      var isInDialog =
        rect.top <= event.clientY &&
        event.clientY <= rect.top + rect.height &&
        rect.left <= event.clientX &&
        event.clientX <= rect.left + rect.width;
      if (!isInDialog) {
        modal.close();
      }
    });
  }
}
