var gulp = require('gulp');
var livereload = require('gulp-livereload');
var browserify = require('browserify');
var babelify = require('babelify');
var source = require('vinyl-source-stream'); 
var concat = require('gulp-concat');

var config = {
    paths: {
        html: './src/*.html',
        js: './src/**/*.js',
        jsx: './src/**/*.jsx',
        css: [
            'node_modules/bootstrap/dist/css/bootstrap.min.css',
            'node_modules/bootstrap/dist/css/bootstrap-theme.min.css'
        ],
        mainJS: './src/main.jsx',
        wwwroot: './wwwroot'
    }
}

gulp.task('html', function () {
    gulp.src(config.paths.html)
    .pipe(gulp.dest(config.paths.wwwroot))
    .pipe(livereload());
});

gulp.task('css', function () {
    gulp.src(config.paths.css)
    .pipe(concat('bundle.css'))
    .pipe(gulp.dest(config.paths.wwwroot + '/css'));
});

gulp.task('js', function () {
    browserify(config.paths.mainJS)
    .transform("babelify", {presets: ["react"]})
    .bundle()
    .on('error', console.error.bind(console))
    .pipe(source('bundle.js'))
    .pipe(gulp.dest(config.paths.wwwroot + '/scripts'))
    .pipe(livereload());
});

gulp.task('watch', function() {
   livereload.listen();
   gulp.watch(config.paths.html, ['html']);
   gulp.watch(config.paths.js, ['js']);
   gulp.watch(config.paths.jsx, ['js']); 
});

gulp.task('default', ['html', 'css', 'js', 'watch']);