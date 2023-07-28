import { createDirectiveFactory, SpectatorDirective } from '@ngneat/spectator/jest';
import { ShowPasswordDirective } from '../directives';

describe('AutofocusDirective', () => {
  let spectator: SpectatorDirective<ShowPasswordDirective>;

  const createDirective = createDirectiveFactory({
    directive: ShowPasswordDirective,
    template: '<input [abpShowPassword]="false" />',
  });
  

  beforeEach(() => {
    spectator = createDirective();
  });

  test('should be created', () => {
    expect(spectator).toBeTruthy();
    console.log(spectator);
  });

  // test('should have 10ms delay', () => {
  //   expect(directive.delay).toBe(10);
  // });

  // test('should focus element after given delay', done => {
  //   timer(0).subscribe(() => expect('input').not.toBeFocused());
  //   timer(11).subscribe(() => {
  //     expect('input').toBeFocused();
  //     done();
  //   });
  // });
});
