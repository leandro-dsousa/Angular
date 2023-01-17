import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css'],
})
export class NavMenuComponent {
  isExpanded = false;

  notifications: Notification[] = [];

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit() {
    var profile_dropdown = document.getElementById(
      'profile-dropdown'
    ) as HTMLDivElement;
    var notifications_dropdown = document.getElementById(
      'notification-dropdown'
    ) as HTMLDivElement;
    var profile = document.getElementById('profile') as HTMLAnchorElement;
    var notifications = document.getElementById(
      'notifications'
    ) as HTMLAnchorElement;
    var body = document.querySelector('body') as HTMLBodyElement;

    profile.addEventListener('click', function (event) {
      if (
        profile_dropdown
          .getAttributeNames()
          .find((element) => element === 'open') !== undefined
      ) {
        profile_dropdown.removeAttribute('open');
        profile_dropdown.setAttribute('close', 'close');
      } else {
        profile_dropdown.removeAttribute('close');
        profile_dropdown.setAttribute('open', 'open');
      }
    });

    notifications.addEventListener('click', function (event) {
      if (
        notifications_dropdown
          .getAttributeNames()
          .find((element) => element === 'open') !== undefined
      ) {
        notifications_dropdown.removeAttribute('open');
        notifications_dropdown.setAttribute('close', 'close');
      } else {
        notifications_dropdown.removeAttribute('close');
        notifications_dropdown.setAttribute('open', 'open');
      }
    });

    body.addEventListener('click', function (event) {
      var rect_profile_dropdown = profile_dropdown.getBoundingClientRect();
      var isInDialog_profile_dropdown =
        rect_profile_dropdown.top <= event.clientY &&
        event.clientY <=
          rect_profile_dropdown.top + rect_profile_dropdown.height &&
        rect_profile_dropdown.left <= event.clientX &&
        event.clientX <=
          rect_profile_dropdown.left + rect_profile_dropdown.width;

      var rect_profile = profile.getBoundingClientRect();
      var isInDialog_profile =
        rect_profile.top <= event.clientY &&
        event.clientY <= rect_profile.top + rect_profile.height &&
        rect_profile.left <= event.clientX &&
        event.clientX <= rect_profile.left + rect_profile.width;

      var rect_notifications_dropdown =
        notifications_dropdown.getBoundingClientRect();
      var isInDialog_notifications_dropdown =
        rect_notifications_dropdown.top <= event.clientY &&
        event.clientY <=
          rect_notifications_dropdown.top +
            rect_notifications_dropdown.height &&
        rect_notifications_dropdown.left <= event.clientX &&
        event.clientX <=
          rect_notifications_dropdown.left + rect_notifications_dropdown.width;

      var rect_notifications = notifications.getBoundingClientRect();
      var isInDialog_notifications =
        rect_notifications.top <= event.clientY &&
        event.clientY <= rect_notifications.top + rect_notifications.height &&
        rect_notifications.left <= event.clientX &&
        event.clientX <= rect_notifications.left + rect_notifications.width;

      if (!isInDialog_profile_dropdown && !isInDialog_profile) {
        profile_dropdown.removeAttribute('open');
        profile_dropdown.setAttribute('close', 'close');
      }

      if (!isInDialog_notifications_dropdown && !isInDialog_notifications) {
        notifications_dropdown.removeAttribute('open');
        notifications_dropdown.setAttribute('close', 'close');
      }
    });
  }
}

interface Notification {
  id: string;
  title: Title;
  body: Body;
}

interface Body {
  _body: string;
}

interface Title {
  _title: string;
}
