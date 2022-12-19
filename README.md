# faker-dot-cs

A good faith effort to port of faker.js to C#.
In some cases, the API is not identical, but the intent is to be as close as possible and include some of hte nice-to-haves from c#.

Examples of deviation include:
instead of `.number()` we have `.Int(), .Double(), .Float(), .Decimal()`

## Original Notes

https://fakerjsdocs.netlify.app/

https://github.com/Marak/faker.js/tree/master/lib/locales/en

## TODO:

There are several lines marked with `// TODO:` in the code. These are things that need to be done before this is ready for production use.

## Usage

`sh make build` will build the project.
`sh make test` will run the tests.
`sh make clean` will clean the project.
`sh make restore` will restore the project.
